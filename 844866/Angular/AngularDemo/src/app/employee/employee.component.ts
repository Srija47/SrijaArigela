import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'my-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent  {
firstName:string='Raj';
lastName:string="T";
Email:string="Raj@CTS.com";
Age:Number=21;
getStyle(){
  let styles={"font-style":"italic","color":"brown"};
  return styles;
}
}
