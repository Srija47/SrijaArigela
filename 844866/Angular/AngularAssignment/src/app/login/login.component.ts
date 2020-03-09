import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
uname:string;
pwd:string;
errmsg:string;
  constructor(private route:Router) { 
  }
  ngOnInit() {
  }
public Validate()
{
  if(this.uname=="buyer"&&this.pwd=="123")
  {
    sessionStorage.setItem("bn",this.uname);
     this.route.navigateByUrl('buyer');
  }
  else if(this.uname=="seller"&&this.pwd=="1234")
  {
    sessionStorage.setItem("sn",this.uname);
    this.route.navigateByUrl('seller');
  }
  else if(this.uname=="admin"&&this.pwd=="12345")
  {
    sessionStorage.setItem("un",this.uname);
    this.route.navigateByUrl('admin');
  }
  else{
    this.errmsg="Invalid Login Details";
  }
}

}
