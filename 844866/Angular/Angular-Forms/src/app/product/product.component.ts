import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
product:FormGroup;
added=false;
constructor(private formBuilder:FormBuilder) {
  
 }

ngOnInit() {
      this.product=this.formBuilder.group({
        id:['',Validators.required],
        name:['',Validators.required],
        price:['',Validators.required],
        stock:['',Validators.required]
      });                                                                                                                                                                                                                                                                                                                                               
}
onAdd()
{
  this.added=true;  
  if(this.product.invalid)
  {
    return ;
  }
  else
  {
    alert("Form is Validated");
  }
}
get f() { return this.product.controls; }
onReset()
{
this.added=false;
this.product.reset();
}
}
