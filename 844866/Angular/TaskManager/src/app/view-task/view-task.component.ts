import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Task } from '../Models/task';

@Component({
  selector: 'app-view-task',
  templateUrl: './view-task.component.html',
  styleUrls: ['./view-task.component.css']
})
export class ViewTaskComponent implements OnInit {
list:Task[]=[];
  constructor(private route:Router) { 
    if (localStorage.getItem("listdata"))
    {
      this.list=JSON.parse(localStorage.getItem("listdata"));
    }
  }

  ngOnInit() {
  }

}
