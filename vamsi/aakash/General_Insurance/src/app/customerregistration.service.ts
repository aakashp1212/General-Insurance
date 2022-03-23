import { Injectable } from '@angular/core';
import {HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerregistrationService {
    post(arg0: string) {
        throw new Error('Method not implemented.');
    }

  constructor(private register:HttpClient ) {

   }

   getAllCustomer():Observable<any>{
     return this.register.get('http://localhost:45903/api/Registration/all' )
   }
   addCustomer(data: any):Observable<any>{
    return this.register.post('http://localhost:45903/api/Registration', data)
  }
  getCustomerById(data: any):Observable<any>{
    return this.register.post('http://localhost:45903/api/Registration/', data)
  }
}
