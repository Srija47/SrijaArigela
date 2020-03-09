import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
Item:Student
  constructor() { 
    this.Item=new Student();
    this.Item.Sid=1;
    this.Item.Sname="Rohan";
    this.Item.Std="II";
    this.Item.Age=13;
    this.Item.DOB=new Date(2008,12,23);
  }

  ngOnInit() {
  }

}
