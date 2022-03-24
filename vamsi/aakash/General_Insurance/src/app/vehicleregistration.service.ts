import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {Observable  } from "rxjs";
import { VehicleTypes } from './Models/vehicletypes';
import { Vehicles } from './Models/vehicle.model';

// @Injectable(

// )
// export class VehicleregistrationService {




//   constructor(private registervehicle : HttpClient ) {

//    }


//    addvehicledetails(data: any) :Observable<any>{
//      return this.registervehicle.post('http://localhost:37841/api/Buyinsurance/addvehicledetails',data)
     
//    }
 
// }

@Injectable({

  providedIn: 'root'

})

export class VehicleregistrationService {



 

  constructor(private _http: HttpClient) { }

   
  addVehicleData(data: any):Observable<any>{
    return this._http.post('http://localhost:37841/api/Buyinsurance', data)
  }
 

}



