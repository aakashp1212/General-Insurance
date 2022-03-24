import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ConfirmedValidator } from 'src/app/validators/confirm-password-validator';
import { passwordValidator} from 'src/app/validators/password-validators';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';
import { CustomerregistrationService } from '../customerregistration.service';
import { ThisReceiver } from '@angular/compiler';
import { Router } from '@angular/router';
import { VehicleregistrationService } from '../vehicleregistration.service';


@Component({

  selector: 'app-registration-form',
  templateUrl: 'customer-registration.component.html',
 
})
export class  CustomerRegistrationComponent implements OnInit {

    
 
  

    
    private _registrationform: FormGroup = this._fb.group({
        firstName: ['',
            [Validators.required]
        ],
     
        email: [
            '',
            [Validators.required, Validators.email]
        ],
       
        Address :['',[Validators.required]],
        password: [
            '',
            [
                Validators.required,
                passwordValidator(6,10)
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
    
    public registerdata: any;

 
    constructor(private _fb: FormBuilder, private registerService: CustomerregistrationService, private _router: Router,private registerser : VehicleregistrationService) { }



    ngOnInit(): void {

     this.getAllCustomer();
      


    }

    public savedata(): void {

        this.registerService.addCustomer(this._registrationform.value).subscribe(result => {

            alert(`data added successfully=${result}`);



        });



    }
    private getAllCustomer(): void {

        this.registerService.getAllCustomer().subscribe(data => { this.registerdata = data });



    }



      submitData(data: any) {
       

        

            this.registerService.addCustomer(data).subscribe(
               
              
               {
                    next: (result: any) => alert(result),
                    error: (err) => console.log(err),
                complete: () => {
                         this._router.navigateByUrl('http://localhost:37841/api/Buyinsurance/addvehicledetails')
                   }
            
           
                });
    
        
      }
      
       

}
  
    
    
      
    