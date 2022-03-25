import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ClaimreasonsService {

  constructor(private _http: HttpClient) { }


  addclaim(data: any):Observable<any>{

    return this._http.post('http://localhost:37841/api/Claiminsurance',data);
  }

}
