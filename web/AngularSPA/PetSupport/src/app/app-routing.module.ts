import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {BecomePetsitterComponent} from './pages/become-petsitter/become-petsitter.component';
import {MainPageComponent} from './pages/main-page/main-page.component';
import {LoginFormComponent} from './common/components/organism/login-form/login-form.component';
import {EditProfileComponent} from './pages/edit-profile/edit-profile.component';
import {NotAuthorizedComponent} from './common/auth/not-authorized/not-authorized.component';


const routes: Routes = [
  {path: 'main-page', component: MainPageComponent},
  {path: 'become-petsitter', component: BecomePetsitterComponent},
  {path: 'login', component: LoginFormComponent},
  {path: 'edit-profile', component: EditProfileComponent},
  {path: 'not-authorized', component: NotAuthorizedComponent},
  {
    path: 'register-form', loadChildren: () =>
      import('./pages/register/register.module').then((m) => m.RegisterModule),
  },
  {
    path: 'petsitters', loadChildren: () =>
      import('./pages/petsitters/petsitters.module').then((m) => m.PetsittersModule),
  },
  {
    path: 'user', loadChildren: () =>
      import('./pages/user/user.module').then((m) => m.UserModule),
  },

  {path: '', redirectTo: '/main-page', pathMatch: 'full'},
  /*   ** is last route, add new only above ^^^  */
  {path: '**', component: MainPageComponent} // We can add 404 page here later
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {relativeLinkResolution: 'legacy'})],
  exports: [RouterModule]
})
export class AppRoutingModule {
}
