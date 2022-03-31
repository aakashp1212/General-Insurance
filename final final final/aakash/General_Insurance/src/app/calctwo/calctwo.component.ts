import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calctwo',
  templateUrl: './calctwo.component.html',
  styleUrls: ['./calctwo.component.css']
})
export class CalctwoComponent implements OnInit {

  age: any;
result: any;
amount : any;
claim: any=0;
message: string=" ";


  constructor() { }

  ngOnInit(): void {
   
  }
  calculate () {

if(this.age <= 5)
 this.result=100000;  
else if (this.age > 10 && this.age <= 15 )
this.result=50000;
else if (this.age > 15 && this.age <=20 )
this.result=20000;
else if (this.age > 20 && this.age <=30 )
this.result=5000;
else if (this.age > 30  )
this.result="not eligible";

    }
}
