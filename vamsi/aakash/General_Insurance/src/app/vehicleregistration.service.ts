import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {Observable  } from "rxjs";

@Injectable(

)
export class VehicleregistrationService {




  constructor(private registervehicle : HttpClient ) {

   }


   addvehicledetails(data: any) :Observable<any>{
     return this.registervehicle.post('http://localhost:45903/api/Buyinsurance/addvehicledetails',data)
     
   }
 
}



