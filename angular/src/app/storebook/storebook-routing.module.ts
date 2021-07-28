import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StorebookComponent } from './storebook.component';

const routes: Routes = [{ path: '', component: StorebookComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class StorebookRoutingModule { }
