
import { importExpr } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators,FormBuilder } from '@angular/forms';

import { ActivatedRoute, Params, Router } from '@angular/router';
import { CustomerregistrationService } from '../customerregistration.service';

import { LoginService } from '../login.service';




@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {

  



  private _login: FormGroup = this._lb.group(
    {
    
    email: [ '', [Validators.required, Validators.email]],  
      
    password: [ '',  [Validators.required]]
    
    }
);
  email: any;
  password:any;
public get login(): FormGroup {
    return this._login;
}
public set login(value: FormGroup) {
    this._login = value;
}

constructor(private _lb: FormBuilder,private router: Router,private _service:LoginService) { }

  ngOnInit(): void {
    

    
  }
  

  
  submitData() {
    console.log(this.login);
    this.email=this._login.value.email;
    this.password=this._login.value.password;
    this._service.forlogin(this.email,this.password).subscribe(res=>{alert(res.message)});
    // this.router.navigate(['/customerdashboard']);
  
    
  }
}

