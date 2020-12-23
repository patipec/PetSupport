import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import { BecomePetsitterComponent } from './become-petsitter/become-petsitter.component';
import {MainPageComponent} from './main-page/main-page.component';
import {PettsittersComponent} from './petsitters/pettsiters/pettsiters.component';
import {PetsitterComponent} from './petsitters/petsitter/petsitter.component';

const routes: Routes = [
  {path: 'main-page', component: MainPageComponent},
  {path: 'become-petsitter', component: BecomePetsitterComponent},
  {path: 'petsitters', component: PettsittersComponent},
  {path: 'petsitters/:id', component: PetsitterComponent},
  { path: '',   redirectTo: '/main-page', pathMatch: 'full' },

  /*   ** is last route, add new only above ^^^  */
  {path: '**', component: MainPageComponent} // We can add 404 page here later
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
