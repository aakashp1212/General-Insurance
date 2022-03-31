

import { Component, OnInit } from '@angular/core';
import { FormGroup,Validators,FormBuilder} from '@angular/forms'
import { RenewserviceService } from './renewservice.service';


@Component({
  selector: 'app-renew',
  templateUrl: './renew.component.html',
  styleUrls: ['./renew.component.css']
})
export class RenewComponent implements OnInit {

  private _renew: FormGroup = this._fb.group(
    {
    policyNumber: ['',[Validators.required]],
    Email: [ '', [Validators.required, Validators.email]],  
      
    contactNo: [ '',  [Validators.required]]
    
    }
);
public get renew(): FormGroup {
    return this._renew;
}
public set renew(value: FormGroup) {
    this._renew = value;
}

  constructor(private _fb: FormBuilder, private _updaterenew : RenewserviceService) { }

  ngOnInit(): void {
  }

  submitData(data: any) {
  this._updaterenew.updatedetails(data).subscribe();

   
  }


  
}
