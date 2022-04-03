import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { plansservice } from './plans.service';

@Component({
  selector: 'app-plan-table',
  templateUrl: './plan-table.component.html',
  styleUrls: ['./plan-table.component.css']
})
export class PlanTableComponent implements OnInit {

  constructor(private ng :plansservice, private route: Router) { }

  ngOnInit(): void {


  }

  selectedplan(data:any){

    this.ng.submitdata(data).subscribe(result => {console.log(result)}); 

  }

}
