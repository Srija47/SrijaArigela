import { Component, OnInit } from '@angular/core';
import { Project } from '../Model/project';


@Component({
  selector: 'app-demo4',
  templateUrl: './demo4.component.html',
  styleUrls: ['./demo4.component.css']
})
export class Demo4Component implements OnInit {
list:Project[]=[];
pid:number;
pname:string;
domain:string;
startdate:Date;
enddate:Date;
val:boolean=false;
item:Project;
  constructor() { 
    this.list=[
      {pid:1,pname:'Chandu',domain:'DotNet',startdate:new Date(2019,12,28),enddate:new Date(2020,3,20)},
      {pid:1,pname:'Yash',domain:'DotNet',startdate:new Date(2019,12,28),enddate:new Date(2020,3,20)},
      {pid:1,pname:'Bhagya',domain:'DotNet',startdate:new Date(2019,12,28),enddate:new Date(2020,3,20)},
      {pid:1,pname:'Sanj',domain:'DotNet',startdate:new Date(2019,12,28),enddate:new Date(2020,3,20)},
    ]
  }

  ngOnInit() {
  }
public Add()
{
  this.item.pid=this.pid;
  this.item.pname=this.pname;
  this.item.domain=this.domain;
  this.item.startdate=this.startdate;
  this.item.enddate=this.enddate;
  this.list.push(this.item);
}
public Setval()
{
  this.val=!this.val;
  console.log(this.item);
}
}

