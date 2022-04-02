  import { Component, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
  import { Router } from '@angular/router';
import { table } from 'console';
import { insuranceplantype } from '../Models/plans.model';
  import { plansservice } from './plans.service';
 

  @Component({
    selector: 'app-plan-table',
    templateUrl: './plan-table.component.html',
    styleUrls: ['./plan-table.component.css']
  })
  export class PlanTableComponent implements OnInit {
  
_res:any;
res:any;
  
  formValue !: FormGroup;
  employeeData !: any;
  employeeObj : insuranceplantype = new insuranceplantype();
  showAdd !: boolean;
  showUpdate !: boolean;
  @Input() receive !: string;
  @Input() mobileSpecification !: any;
  role:string =""


  
    constructor(private ng :plansservice, private route: Router,private formBuilder: FormBuilder,) { }

    ngOnInit(): void {

      this.formValue = this.formBuilder.group({
        durationValue: [''],
        planName: [''],
        
      })
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

 

    editEmployeeDetail(){
      this.employeeObj.durationValue = this.formValue.value.firstName;
      this.employeeObj.planName = this.formValue.value.lastName;
     
     this.ng.Updatedetails(this.employeeObj)
     .subscribe(_res=>{
       alert("Updated Successfully")
       let ref = document.getElementById('close');
       ref?.click();
     
     })
   }
   onEdit(row : any){

     this.formValue.controls['durationValue'].setValue(row.durationValue);
     this.formValue.controls['planName'].setValue(row.planName);
     this.showUpdate = true;
     this.showAdd = false;
   }


  }


