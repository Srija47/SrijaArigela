import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Model/student';

@Component({
  selector: 'app-demo3',
  templateUrl: './demo3.component.html',
  styleUrls: ['./demo3.component.css']
})
export class Demo3Component implements OnInit {
list:Student[]=[];
sid:number;
sname:string;
std:string;
age:number;
stds:string[]=["I","II","III","IV","V"]
item:Student;
val:boolean=false;
  constructor() { 
    this.list=[
      {sid:1,sname:'Rohan',std:'I',age:12},
      {sid:2,sname:'Ram',std:'I',age:10},
      {sid:3,sname:'Jeson',std:'II',age:17},
      {sid:4,sname:'Koman',std:'III',age:19},
      {sid:5,sname:'Monica',std:'I',age:10},
      {sid:6,sname:'Rajan',std:'II',age:16}
    ]
  }

  ngOnInit() {
  }
  public setval()
  {
    this.val=!this.val;
  }
public Add()
{
  this.item=new Student();
this.item.sid=this.sid;
this.item.sname=this.sname;
this.item.age=this.age;
this.item.std=this.std;
this.list.push(this.item);// add item to array

}
}
