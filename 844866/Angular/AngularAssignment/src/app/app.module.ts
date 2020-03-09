import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { BuyerComponent } from './buyer/buyer.component';
import { SellerComponent } from './seller/seller.component';
import { AdminComponent } from './admin/admin.component';
import { BuyItemComponent } from './Buyer/buy-item/buy-item.component';
import { ViewCartComponent } from './Buyer/view-cart/view-cart.component';
import { PaymentComponent } from './Buyer/payment/payment.component';
import { AddItemComponent } from './Seller/add-item/add-item.component';
import { ViewItemComponent } from './Seller/view-item/view-item.component';
import { AddCategoryComponent } from './Admin/add-category/add-category.component';
import { AddRemoveBuyerComponent } from './Admin/add-remove-buyer/add-remove-buyer.component';
import { AddRemoveSellerComponent } from './Admin/add-remove-seller/add-remove-seller.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    BuyerComponent,
    SellerComponent,
    AdminComponent,
    BuyItemComponent,
    ViewCartComponent,
    PaymentComponent,
    AddItemComponent,
    ViewItemComponent,
    AddCategoryComponent,
    AddRemoveBuyerComponent,
    AddRemoveSellerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
