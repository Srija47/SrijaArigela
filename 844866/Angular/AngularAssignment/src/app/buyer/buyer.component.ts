import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-buyer',
  templateUrl: './buyer.component.html',
  styleUrls: ['./buyer.component.css']
})
export class BuyerComponent implements OnInit {
  
    constructor(private route:Router) { 
    }
    ngOnInit() {
    }
  public logout()
  {
    sessionStorage.clear();
    this.route.navigate(['login']);
    this.route.navigateByUrl('login');
  }
  }

