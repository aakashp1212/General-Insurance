import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {Observable  } from "rxjs";
import { Router } from '@angular/router';

@Injectable(

)
export class plansservice {




  constructor(private _plansservice : HttpClient, private router: Router ) {

   }

   submitdata(data: any):Observable<any>{
       return this._plansservice.post('http://localhost:37841/api/Buyinsurance/plan', data);
   }


 
}



