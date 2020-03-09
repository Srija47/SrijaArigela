import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators} from '@angular/forms';
import { Employee } from '../employee';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
list:Employee[]=[];
employeeForm:FormGroup;
submitted=false;
item:Employee;
  constructor(private formBuilder:FormBuilder) {
   }

  ngOnInit() {
    this.employeeForm=this.formBuilder.group({
      id:['',[Validators.required,Validators.pattern("^[A-Z][0-9]{4}$")]],
      Name:['',[Validators.required,Validators.pattern('^[A-Z]{3,8}$')]],
      joinDate:['',Validators.required],
      designation:['',Validators.required],
      mobile:['',[Validators.required,Validators.pattern("^[6-9 0-9]{10}$")]],
      emailid:['',[Validators.required,Validators.email]],
      password:['',[Validators.required,Validators.minLength(8),Validators.pattern("^[a-zA-Z]{7}[!@#$%^&*]{1}$")]]
    })
  }
  onSubmit()
  {
    this.submitted=true;
    if(this.employeeForm.invalid){
      return;
      }
      else{
        alert("Form is Validated");
        this.item=new Employee();
        this.item.id=this.employeeForm.value["id"]
        this.item.Name=this.employeeForm.value["Name"]
        this.item.joinDate=this.employeeForm.value["joinDate"]
        this.item.designation=this.employeeForm.value["designation"]
        this.item.mobile=this.employeeForm.value["mobile"]
        this.item.emailid=this.employeeForm.value["emailid"]
        this.item.password=this.employeeForm.value["password"]
        this.list.push(this.item);
      }
   
  }
  get f() { return this.employeeForm.controls; }
  onReset()
  {
    this.submitted=false;
    this.employeeForm.reset();
  }
}
