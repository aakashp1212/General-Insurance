import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { RouteConfigLoadStart, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ConfirmedValidator } from 'src/app/validators/confirm-password-validator';
import { passwordValidator } from 'src/app/validators/password-validators';
import { RegistrationService } from '../registration.service';




@Component({

    selector: 'app-registration-form',
    templateUrl: 'customer-registration.component.html',

})
export class CustomerRegistrationComponent implements OnInit {


    private _registrationform: FormGroup = this._fb.group({
        firstName: ['',
            [Validators.required]
        ],
        email: [
            '',
            [Validators.required, Validators.email]
        ],

        address: ['', [Validators.required]],
        password: [
            '',
            [
                Validators.required,
                passwordValidator(6, 10)
            ]
        ],
        retypepassword: [
            '',
            [
                Validators.required

            ]
        ],
        contactNo: [
            '',
            [
                Validators.required

            ]

        ]

    },

        {
            validator: ConfirmedValidator('password', 'retypepassword')
        }




    );
    public get registrationform(): FormGroup {
        return this._registrationform;
    }
    public set registrationform(value: FormGroup) {
        this._registrationform = value;
    }

    public adding: any;
    public registerdata: any;
    constructor(private _fb: FormBuilder, private registerservice: RegistrationService,  private _router: Router) { }

    ngOnInit(): void {
        // this.registerservice.GetALLCustomer().subscribe(data=>{this.registerdata=data})
        this.GetALLCustomer();
        // this.init();


    }
    /////////////////////////////////////post method/////////////////

    public savedata(): void {
        this.registerservice.AddCustomer(this._registrationform.value).subscribe(result => {
            alert(`data added successfully=${result}`);

        });

    }

    ///////////////////////////////get all customers///////////////////////////////
    private GetALLCustomer(): void {
        this.registerservice.GetALLCustomer().subscribe(data => { this.registerdata = data });

    }







    // submitData(data:any) {
    // this.registerservice.(this.registrationform.value);


    // }

    
    //  submitData(data:any) {
    //  console.log(this.registrationform.value);


    // }

  




    submitData(data:any) {
        console.log(data);
        this.registerservice.AddCustomer(data.value).subscribe(comeout=>{this.adding=comeout});


        this.registerservice.AddCustomer(data).subscribe(

            {

                next: (res: any) => alert(res),

                error: (err) => console.log(err),

                complete: () => {

                    this._router.navigate(['/vehicle-registration'])

                }

            });

    }
    }






