import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-calctwo',
  templateUrl: './calctwo.component.html',
  styleUrls: ['./calctwo.component.css']
})
export class CalctwoComponent implements OnInit {

  age: any=0;
  result: any;
  amount : any;
  claim: any=0;
  message: string=" ";
  constructor() { }

  ngOnInit(): void {
  }
  calculate (data: any) {console.log(data.value);

    if(this.age < 5   ){
      this.amount=5000;
    
    
    }    
    else if (this.age >10){
    this.amount=10000;
    }
    }
}
