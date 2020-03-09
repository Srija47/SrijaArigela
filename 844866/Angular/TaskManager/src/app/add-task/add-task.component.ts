import { Component, OnInit } from '@angular/core';
import { Task } from '../Models/task';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {
list:Task[];
name:string;
priority:number;
startdate:Date;
enddate:Date;
item:Task;
  constructor(private route:Router) { 
    this.item=new Task();
    this.list=[{name:'srija',priority:5,startdate:new Date(2019,12,28),enddate:new Date(2026,3,20)}];
  }
  public Add()
  {
    
    this.item.name=this.name;
    this.item.priority=this.priority;
    this.item.startdate=this.startdate;
    this.item.enddate=this.enddate;
    if(localStorage.getItem("t2"))
    {
      this.list=JSON.parse(localStorage.getItem("t2"));
    }
    this.list.push(this.item);
    localStorage.setItem("listdata",JSON.stringify(this.list));
    this.route.navigateByUrl('view-task');

  }
  public Reset()
  {
    sessionStorage.clear();
  this.route.navigate(['app']);
  this.route.navigateByUrl('app');
  }
  ngOnInit() {
  }

}
