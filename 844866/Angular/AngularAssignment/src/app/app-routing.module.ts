import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { BuyerComponent } from './buyer/buyer.component';
import { AddItemComponent } from './Seller/add-item/add-item.component';
import { BuyItemComponent } from './Buyer/buy-item/buy-item.component';
import { ViewCartComponent } from './Buyer/view-cart/view-cart.component';
import { PaymentComponent } from './Buyer/payment/payment.component';
import { SellerComponent } from './seller/seller.component';
import { AdminComponent } from './admin/admin.component';
import { AddCategoryComponent } from './Admin/add-category/add-category.component';
import { AddRemoveBuyerComponent } from './Admin/add-remove-buyer/add-remove-buyer.component';
import { AddRemoveSellerComponent } from './Admin/add-remove-seller/add-remove-seller.component';


const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'buyer',component:BuyerComponent, children:[{path:'buy-item',component:BuyItemComponent},{path:'ViewCart',component:ViewCartComponent},{path:'payment',component:PaymentComponent}]},
  {path:'seller',component:SellerComponent,children:[{path:'Add-Item',component:AddItemComponent},{path:'View-Items',component:ViewCartComponent}]},
  {path:'admin',component:AdminComponent,children:[{path:'Add-Category',component:AddCategoryComponent},{path:'Add-RemoveBuyer',component:AddRemoveBuyerComponent},{path:'Add-RemoveSeller',component:AddRemoveSellerComponent}]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
