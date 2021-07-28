import { Component, OnInit } from '@angular/core';
import { ListService, PagedResultDto } from '@abp/ng.core';
import { PurchaseService, PurchaseDto} from '@proxy';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.scss'],
  providers: [ListService],
})
export class PurchaseComponent implements OnInit {

  purchase = { items: [], totalCount: 0 } as PagedResultDto<PurchaseDto>;

  selectedPurchase = {} as PurchaseDto;

  form: FormGroup;
  formEdit: FormGroup;

  thenBlock = null;
  elseBlock = null;

  isModalOpen = false;


  constructor(
    public readonly list: ListService,
    private purchaseService: PurchaseService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService
  ) { }

  ngOnInit(): void {
    const purchaseStreamCreator = (query) => this.purchaseService.getList(query);

    this.list.hookToQuery(purchaseStreamCreator).subscribe((response) => {
      this.purchase = response;
    });
  }
  createPurchase() {
    this.selectedPurchase = {} as PurchaseDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editPurchase(id: string) {
    this.purchaseService.get(id).subscribe((purchase) => {
      this.selectedPurchase = purchase;
      this.editForm();
      this.isModalOpen = true;
    });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.purchaseService.delete(id).subscribe(() => this.list.get());
      }
    });
  }

  buildForm() {
    this.form = this.fb.group({
      bookName: [this.selectedPurchase.bookName || '', Validators.required],
      quantity: [this.selectedPurchase.quantity || null, Validators.required],
    });
  }

  editForm() {
    this.form = this.fb.group({
      bookName: [{value: this.selectedPurchase.bookName, disabled: true}],
      quantity: [this.selectedPurchase.quantity || Validators.required],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }


    const request = this.selectedPurchase.id
      ? this.purchaseService.update(this.selectedPurchase.id, this.form.value)
      : this.purchaseService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }

}
