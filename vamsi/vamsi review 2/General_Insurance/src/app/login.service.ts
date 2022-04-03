import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private _http:HttpClient) { }


  forlogin(data:any,data1:any):Observable<any>{
    return this._http.post('',data,data1);
    
  }
}
