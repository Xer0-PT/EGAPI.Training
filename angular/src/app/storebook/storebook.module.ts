import { NgModule } from '@angular/core';
import { StorebookRoutingModule } from './storebook-routing.module';
import { StorebookComponent } from './storebook.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [StorebookComponent],
  imports: [
    SharedModule,
    StorebookRoutingModule
  ]
})
export class StorebookModule { }
