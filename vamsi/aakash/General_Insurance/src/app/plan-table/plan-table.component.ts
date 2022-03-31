  import { Component, OnInit, Output } from '@angular/core';
  import { Router } from '@angular/router';
  import { plansservice } from './plans.service';
 

  @Component({
    selector: 'app-plan-table',
    templateUrl: './plan-table.component.html',
    styleUrls: ['./plan-table.component.css']
  })
  export class PlanTableComponent implements OnInit {
  res : any;
    constructor(private ng :plansservice, private route: Router) { }

    ngOnInit(): void {


    }

    // public savedata(plannew : any): void {

    //   this.ng.selectdata(plannew).subscribe(result => {

    //       alert(`data added successfully=${result}`);



    //   });

    submitData(data:any){

      this.ng.selectdata(data).subscribe(result => {this.res= result});

  }




  onclick(){
    alert ("Congrats the payment is done");
  }

  submitrenew(data: any) {
    this.ng.updatedetails(data).subscribe();
  
    
    }


  }


