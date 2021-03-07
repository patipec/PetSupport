import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {BecomePetsitterComponent} from './pages/become-petsitter/become-petsitter.component';
import {MainPageComponent} from './pages/main-page/main-page.component';
import {PettsittersComponent} from './pages/petsitters/pettsiters.component';
import {PetsitterComponent} from './pages/petsitters/petsitter/petsitter.component';
import {LoginFormComponent} from './common/components/login-form/login-form.component';
import {ContactFormComponent} from './pages/contact-form/contact-form.component';
import {ContactFormSuccessComponent} from './pages/contact-form/contact-form-success/contact-form-success.component';
import {EditProfileComponent} from './pages/edit-profile/edit-profile.component';
import {LoginAuthGuard} from './common/auth/login-guard';
import {NotAuthorizedComponent} from './common/auth/not-authorized/not-authorized.component';
import {MessagesListComponent} from './user/messages/messages-list/messages-list.component';
import {MessageComponent} from './user/messages/message/message.component';


const routes: Routes = [
  {path: 'main-page', component: MainPageComponent},
  {path: 'become-petsitter', component: BecomePetsitterComponent},
  {path: 'register-form', loadChildren: () =>
      import('./pages/register/register.module').then((m) => m.RegisterModule),
  },
  {path: 'petsitters', loadChildren: () =>
      import('./pages/petsitters/petsitters.module').then((m) => m.PetsittersModule),
  },
  {path: 'messages/:id', component: MessageComponent, canActivate: [LoginAuthGuard]},
  {path: 'messages', component: MessagesListComponent, canActivate: [LoginAuthGuard]},

  {path: 'contact-form/:id', component: ContactFormComponent, canActivate: [LoginAuthGuard]},
  {path: 'contact-form/:id/success', component: ContactFormSuccessComponent, canActivate: [LoginAuthGuard]},

  {path: 'login', component: LoginFormComponent},
  {path: 'edit-profile', component: EditProfileComponent},
  {path: 'not-authorized', component: NotAuthorizedComponent},
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
