import { Component, OnInit } from '@angular/core';
import { ɵNgClassR2Impl } from '@angular/common';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
res1:number;
res2:number;
  constructor() { }

  ngOnInit() {
  }
  public add(n1:number,n2:number)
  {
   this.res1=Number(n1)+Number(n2);
  }
  public subtract(n1:number,n2:number)
  {
    this.res2=Number(n1)-Number(n2);
  }
}
