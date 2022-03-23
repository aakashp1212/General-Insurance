import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { LoginComponent } from './login/login.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { HelpComponent } from './help/help.component';
import { FaqComponent } from './faq/faq.component';
import { CustomerRegistrationComponent } from './customer-registration/customer-registration.component';
import { ClaimComponent } from './claim/claim.component';
import { CalculateInsuranceComponent } from './calculate-insurance/calculate-insurance.component';
import { RenewComponent } from './renew/renew.component';
import { CalcfourComponent } from './calcfour/calcfour.component';
import { CalctwoComponent } from './calctwo/calctwo.component';
import { VehicleRegistrationComponent } from './vehicle-registration/vehicle-registration.component';


const routes: Routes = [

   { path: 'login', component: LoginComponent },
   { path: 'contact', component: ContactComponent },
   { path: 'aboutus', component: AboutusComponent },
   { path: 'help', component: HelpComponent },
   { path: 'faq', component: FaqComponent },
   { path: 'contact', component: ContactComponent },
   
   { path: 'claiminsurance', component: ClaimComponent },
  
   { path: 'renewinsurance', component: RenewComponent },
   {path:'customer-registration', component:CustomerRegistrationComponent},

   { path: 'estimate-insurance', component: CalculateInsuranceComponent} , 

    { path: 'calcfour', component: CalcfourComponent} ,

    { path: 'calctwo', component: CalctwoComponent} ,
   {path: 'vehicleregistration', component: VehicleRegistrationComponent},
  
   { path: '', component: HomeComponent,pathMatch:"full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
