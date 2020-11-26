import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {MainPageComponent} from './main-page/main-page/main-page.component';
import {PettsitersComponent} from './petsitters/pettsiters/pettsiters.component';

const routes: Routes = [
  {path: 'main-page', component: MainPageComponent},
  {path: 'petsitters', component: PettsitersComponent},
  { path: '',   redirectTo: '/main-page', pathMatch: 'full' },

  /*   ** is last route, add new only above ^^^  */
  {path: '**', component: MainPageComponent} // We can add 404 page here later
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
