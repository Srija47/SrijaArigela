import { BrowserModule } from '@angular/platform-browser';
import { NgModule,Component } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import {RouterModule,Routes} from '@angular/router';
import { AppComponent } from './app.component';
import { FirstPageComponent } from './myDemo/first-page.component';
import { SecondPageComponent } from './myDemo/second-page.component';
const appRoutes:Routes=[
  {path:"secondpage",component:SecondPageComponent},
  {path:"firstpage",component:FirstPageComponent},
  //{path:"",redirectTo:"app-root",pathMatch:'full'},
];
@NgModule({
  declarations: [
    AppComponent,
    FirstPageComponent,
    SecondPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
