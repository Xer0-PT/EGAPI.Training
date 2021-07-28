import { NgModule } from '@angular/core';
import { PurchaseRoutingModule } from './purchase-routing.module';
import { PurchaseComponent } from './purchase.component';
import { SharedModule } from '../shared/shared.module';

@NgModule({
  declarations: [PurchaseComponent],
  imports: [
    SharedModule,
    PurchaseRoutingModule
  ]
})
export class PurchaseModule { }
