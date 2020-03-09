import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  //title = 'AngularDemo';
  title:string=null;
  num:number=20;
  imagepath:string='assets/images/jerry.png';
  fname:string='Ram';
  lname:string='R';
  isdisabled:boolean=false;
  mystyle:string="boldclass italicclass"
  applyStyle:boolean=true;
getname():string
{
  this.fname=this.fname.toUpperCase();
  return this.fname+" "+this.lname;
}
}
