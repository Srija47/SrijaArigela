import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Demostrdir';
  Customer:any[]=[{"name":'Raj',"country":'India',"age":21},
  {"name":"Ram","country":"US","age":29},
  {"name":"Ashok","country":"UK","age":26}];

  StudentbyCountry:any[]=[
    {"country":"India","student":[{"name":"Jay","age":23},{"name":"Ravi","age":23}]},
    {"country":"USA","student":[{"name":"Tom","age":23},{"name":"Jane","age":23}]}
  ]
  
}
