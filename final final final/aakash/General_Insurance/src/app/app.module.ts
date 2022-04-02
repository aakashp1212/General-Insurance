import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {  ROUTES,Router,RouterModule} from "@angular/router";
import { HomeComponent } from './home/home.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { LoginComponent } from './login/login.component';
import { VehicleRegistrationComponent } from './vehicle-registration/vehicle-registration.component';
import { CustomerRegistrationComponent } from './customer-registration/customer-registration.component';
import { PlanTableComponent } from './plan-table/plan-table.component';
import { PaymentComponent } from './payment/payment.component';
import { ClaimComponent } from './claim/claim.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { RenewComponent } from './renew/renew.component';
import { CalculateInsuranceComponent } from './calculate-insurance/calculate-insurance.component';

import { ContactComponent } from './contact/contact.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { HelpComponent } from './help/help.component';
import { FaqComponent } from './faq/faq.component';
import { CalcfourComponent } from './calcfour/calcfour.component';
import { CalctwoComponent } from './calctwo/calctwo.component'
import { HttpClientModule } from '@angular/common/http';
import { CustomerregistrationService } from './customerregistration.service';

import { CalcfourinsuranceService } from './calcfourinsurance.service';
import { VehicleregistrationService } from './vehicleregistration.service';
import { plansservice } from './plan-table/plans.service';
import { ClaimreasonsService } from './claimreasons.service';
import { DashboardComponent } from './dashboard/dashboard.component';

@NgModule({
  declarations: [
    AppComponent,
   
    HomeComponent,
        LoginComponent,
        VehicleRegistrationComponent,
        CustomerRegistrationComponent,
        PlanTableComponent,
        PaymentComponent,
        ClaimComponent,
        RenewComponent,
        CalculateInsuranceComponent,
        ContactComponent,
        AboutusComponent,
        HelpComponent,
        FaqComponent,
        CalcfourComponent,
        CalctwoComponent,
        DashboardComponent
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,FormsModule,ReactiveFormsModule,HttpClientModule
  ],
  exports:[ClaimComponent],
  providers: [CustomerregistrationService,VehicleregistrationService ,CalcfourinsuranceService,plansservice,ClaimreasonsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
