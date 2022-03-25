import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calcfour',
  templateUrl: './calcfour.component.html',
  styleUrls: ['./calcfour.component.css']
})


export class CalcfourComponent implements OnInit {

  age: any=0;
result: any;
amount : any;
claim: any=0;
message: string=" ";


  constructor() { }

  ngOnInit(): void {
   
  }
  calculate (data: any) {

if(this.age < 5   )
  this.amount=5000;  
else
this.amount=10000;

}


}

