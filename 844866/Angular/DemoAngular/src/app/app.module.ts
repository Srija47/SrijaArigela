import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './UI/demo/demo.component';
import { CalculatorComponent } from './EventBinding/calculator/calculator.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    CalculatorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [DemoComponent]
})
export class AppModule { }
