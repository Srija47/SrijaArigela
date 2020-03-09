import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/Models/customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {
  obj:Customer;
  constructor() {
    this.obj={CName:'Raj',Email:'Raj123@gmail.com',Mobile:9994566231,City:'Chennai',Address:"Perungudi,Infotech"};
   }

  ngOnInit() {
  }

}
