import { Injectable } from '@angular/core';
import {  HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RenewserviceService {

  constructor(private _http : HttpClient) { }

  updatedetails(data : any) : Observable<any>{
   return this._http.put('http://localhost:37841/api/Renewinsurance',data);

  }
}
