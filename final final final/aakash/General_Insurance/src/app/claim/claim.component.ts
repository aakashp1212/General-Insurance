import { Component, OnInit } from '@angular/core';
import { FormGroup,Validators,FormBuilder} from '@angular/forms'
import { ClaimreasonsService } from '../claimreasons.service';

@Component({
  selector: 'app-claim',
  templateUrl: './claim.component.html',
  styleUrls: ['./claim.component.css']
})
export class ClaimComponent implements OnInit {

  private _claim: FormGroup = this._fb.group(
    {
    policynumber: ['',[Validators.required]],
   
    phnnumber: [ '',  [Validators.required]],
    Category:['',Validators.required]


    }
);
public get claim(): FormGroup {
    return this._claim;
}
public set claim(value: FormGroup) {
    this._claim = value;
}

res: any;
  constructor(private _fb: FormBuilder, private yo : ClaimreasonsService) { }

  ngOnInit(): void {
  }

  submitData(data:any) {
    this.yo.addclaim(data).subscribe(result => {this.res=result} );
  }

  onclick(){
    alert ("Your claim record is sent to verification");
  }
  
}

