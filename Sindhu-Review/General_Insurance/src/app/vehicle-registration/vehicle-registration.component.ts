import { Component, OnInit } from '@angular/core';
import { FormGroup,Validators,FormBuilder } from '@angular/forms';


@Component({
  selector: 'app-vehicle-registration',
  templateUrl: './vehicle-registration.component.html',
  styleUrls: ['./vehicle-registration.component.css']
})
export class VehicleRegistrationComponent implements OnInit {

  private _vehicleregistration: FormGroup = this._fb.group({
    Manufacturer: ['',
        [Validators.required]
    ],
    Purchasedate: ['',
    [Validators.required]
],
    Model: [
        '',
        [Validators.required]
    ],
   
    DrivingLicenseNumber :['',[Validators.required]],
    RegistrationNumber: [
        '',
        [
            Validators.required
            
        ]
    ],
    EngineNumber: [
        '',
        [
            Validators.required
            
        ]
    ],
    ChasisNumber: [
      '',
      [
          Validators.required
          
      ]
     
    ]

}




);
public get vehicleregistration(): FormGroup {
    return this._vehicleregistration;
}
public set vehicleregistration(value: FormGroup) {
    this._vehicleregistration = value;
}

  constructor(private _fb: FormBuilder) { }

  ngOnInit(): void {
   


  }

  submitData() {
    console.log(this.vehicleregistration)
  }
}



  

