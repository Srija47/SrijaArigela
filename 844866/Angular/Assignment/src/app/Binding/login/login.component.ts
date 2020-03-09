import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/Model/login';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
item:Login
  constructor() {
    this.item=new Login();
    this.item.Uname="Admin";
    this.item.pwd="12345";
    console.log(this.item);
   }

  ngOnInit() {
  }
public OnClick()
{
  if(this.item.Uname == "Admin" && this.item.pwd == "12345"){
    alert("Login Success");
   }
   else {
     alert("Login Failed");
   }
  console.log(this.item);
}
}
