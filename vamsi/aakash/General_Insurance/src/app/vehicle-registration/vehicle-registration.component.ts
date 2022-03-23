import { Component, OnInit } from '@angular/core';
import { FormGroup,Validators,FormBuilder } from '@angular/forms';
import { VehicleregistrationService } from '../vehicleregistration.service';


@Component({
  selector: 'app-vehicle-registration',
  templateUrl: './vehicle-registration.component.html',
  styleUrls: ['./vehicle-registration.component.css']
})
export class VehicleRegistrationComponent implements OnInit {

  private _vehicleregistration: FormGroup = this._fb.group({
    manufacturer: ['',
        [Validators.required]
    ],
//     purchaseDate: ['',
//     [Validators.required]
// ],
    model: [
        '',
        [Validators.required]
    ],
   
    drivingLicenseNumber :['',[Validators.required]],
registrationNumber: [
        '',
        [
            Validators.required
            
        ]
    ],
    engineNumber: [
        '',
        [
            Validators.required
            
        ]
    ],
    chasisNumber: [
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

public register: any;
  constructor(private _fb: FormBuilder, private registervehicle : VehicleregistrationService) { }

  ngOnInit(): void {
   


  }

  public savedata(): void {

    this.registervehicle.addvehicledetails(this._vehicleregistration.value).subscribe((res) => {

        alert(`data added successfully=${res}`);



    });



}

  submitData(data : any) {
    this.registervehicle.addvehicledetails(data).subscribe((turn) => { console.log(turn) });
}



  
}
