import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './Interpolation/demo/demo.component';
//import { ViewComponent } from './Interpolation/view/view.component';
//import { ViewCustomerComponent } from './Interpolation/view-customer/view-customer.component';
import { ViewComponent } from './Property-Binding/view/view.component';
import { ViewCustomerComponent } from './Property-Binding/view-customer/view-customer.component';
import { EventDemoComponent } from './Event-Binding/event-demo/event-demo.component';
import { CalculatorComponent } from './Event-Binding/calculator/calculator.component';
import { Demo1Component } from './TwoWay-Binding/demo1/demo1.component';
import { FormsModule } from '@angular/forms';
import { Demo2Component } from './Twoway-Binding/demo2/demo2.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    ViewComponent,
    ViewCustomerComponent,
    EventDemoComponent,
    CalculatorComponent,
    Demo1Component,
    Demo2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [Demo2Component]
})
export class AppModule { }
