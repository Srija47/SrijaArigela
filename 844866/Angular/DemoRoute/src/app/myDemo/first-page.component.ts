import { Component, OnInit } from '@angular/core';

@Component({
  //selector: 'app-first-page',
  templateUrl: './first-page.component.html',
  styleUrls: ['./first-page.component.css']
})
export class FirstPageComponent implements OnInit {
  title:string="FirstPage"
  name:string='User'
  date:string="04/02/2020"

  constructor() { }

  ngOnInit() {
  }

}
