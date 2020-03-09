import { Component, OnInit } from '@angular/core';
import { FormGroup,FormBuilder,Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm:FormGroup;
  submitted=false;

  constructor(private formBuilder:FormBuilder) { }

  ngOnInit() {
    this.registerForm=this.formBuilder.group({
      title:['',Validators.required],
      firstName:['',[Validators.required,Validators.pattern('^[a-z]{3,6}$')]],
      lastName:['',Validators.required],
      mobile:['',[Validators.required,Validators.pattern("^[6-9][0-9]{9}$")]],
      email:['',[Validators.required,Validators.email]],
      password:['',[Validators.required,Validators.minLength(8)]],
      acceptTerms:[false,Validators.requiredTrue]
    })
  }
  get f() { return this.registerForm.controls; }
  onSubmit()
  {
    this.submitted=true;
    if(this.registerForm.valid){
    alert('SUCCESS!!:-)\n\n');
    console.log(JSON.stringify(this.registerForm.value));
   }
  }
  onReset()
  {
    this.submitted=false;
    this.registerForm.reset();
  }
}
