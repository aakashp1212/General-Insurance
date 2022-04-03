import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-adminlogin',
  templateUrl: './adminlogin.component.html',
  styleUrls: ['./adminlogin.component.css']
})
export class AdminloginComponent implements OnInit {

  private _login: FormGroup = this._lb.group(
    {

      email: ['', [Validators.required, Validators.email]],

      password: ['', [Validators.required]]

    }
  );
  public get login(): FormGroup {
    return this._login;
  }
  public set login(value: FormGroup) {
    this._login = value;
  }
  constructor(private _lb: FormBuilder, private router: Router) { }


  ngOnInit(): void {
  }
  submitData() {

  }

}
