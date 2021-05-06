import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {PetsitterComponent} from './petsitter/petsitter.component';
import {PettsittersComponent} from './pettsiters.component';
import {ContactFormComponent} from '../contact-form/contact-form.component';
import {ContactFormSuccessComponent} from '../contact-form/contact-form-success/contact-form-success.component';
import {MsalGuard} from '@azure/msal-angular';

const routes: Routes = [
  {
    path: '',
    children: [
      {path: '', component: PettsittersComponent, pathMatch: 'full'},
      {path: ':id', component: PetsitterComponent},
      {path: ':id/contact-form', component: ContactFormComponent, canActivate: [MsalGuard]},
      {path: ':id/contact-form/success', component: ContactFormSuccessComponent, canActivate: [MsalGuard]},
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PetsittersRoutingModule {
}

