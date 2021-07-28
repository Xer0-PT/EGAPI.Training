import { NgModule } from '@angular/core';
import { PurchaseRoutingModule } from './purchase-routing.module';
import { PurchaseComponent } from './purchase.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [PurchaseComponent],
  imports: [
    PurchaseRoutingModule,
    SharedModule
  ]
})
export class PurchaseModule { }
