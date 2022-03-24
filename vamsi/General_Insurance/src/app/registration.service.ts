import { Injectable } from '@angular/core';
import {HttpClient  } from "@angular/common/http";
import { Observable } from 'rxjs';
import { ThisReceiver } from '@angular/compiler';

@Injectable()
export class RegistrationService {
 
 
   constructor(private register:HttpClient) { }

  GetALLCustomer():Observable<any>{
     return this.register.get('http://localhost:37841/api/Registration/all')
  }



  AddCustomer(data :any):Observable<any>{
    return this.register.post('http://localhost:37841/api/Registration',data)
 }
  
}
