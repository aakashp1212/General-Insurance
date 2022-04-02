import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import {map, Observable  } from "rxjs";
import { Router } from '@angular/router';

@Injectable(

)
export class plansservice {

  public employeeAPIUrl : string = "http://localhost:37841/api/Renewinsurance";


  constructor(private _plansservice : HttpClient, private router: Router ) {

   }

   selectdata(data: any):Observable<any>{
       return this._plansservice.post('http://localhost:37841/api/Buyinsurance/plan', data);
   }
  //  updatedetails(data : any) : Observable<any>{
  //   return this._plansservice.put('http://localhost:37841/api/Renewinsurance' , data);
 
  //  }

  Updatedetails(data : any){
    return this._plansservice.put<any>(`${this.employeeAPIUrl}update_employee`,data)
    .pipe(map((res:any)=>{
      return res;
    }))
  }
 
}


