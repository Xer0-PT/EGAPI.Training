import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {path: 'books', loadChildren: () => import('./book/book.module').then(m => m.BookModule) }, 
  { path: 'purchases', loadChildren: () => import('./purchase/purchase.module').then(m => m.PurchaseModule) }, 
  { path: 'storebooks', loadChildren: () => import('./storebook/storebook.module').then(m => m.StorebookModule) }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
