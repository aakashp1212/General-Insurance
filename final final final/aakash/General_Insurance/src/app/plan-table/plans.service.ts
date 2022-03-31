import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {Observable  } from "rxjs";
import { Router } from '@angular/router';

@Injectable(

)
export class plansservice {




  constructor(private _plansservice : HttpClient, private router: Router ) {

   }

   selectdata(data: any):Observable<any>{
       return this._plansservice.post('http://localhost:37841/api/Buyinsurance/plan', data);
   }


   updatedetails(data : any) : Observable<any>{
    return this._plansservice.put('http://localhost:37841/api/Renewinsurance/update' , data);
 
  


 
}

}

