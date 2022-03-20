import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClaimComponent } from './claim/claim.component';
import { CustomerRegistrationComponent } from './customer-registration/customer-registration.component';
import { HomeComponent } from './home/home.component';

import { LoginComponent } from './login/login.component';

const routes: Routes = [
 
    
   
   { path: 'login', component: LoginComponent },
   {
     path:'customer-registration', component:CustomerRegistrationComponent
   },
   { path: '', component: HomeComponent,pathMatch:"full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
