import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class DEMO1Component implements OnInit {
val:boolean=false
  constructor() { }

  ngOnInit() {
  }
public Set()
{
  this.val=!this.val;
}
}
