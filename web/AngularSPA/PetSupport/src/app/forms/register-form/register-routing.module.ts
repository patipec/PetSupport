import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {BasicInfoComponent} from './basic-info/basic-info.component';
import {BiFormComponent} from './basic-info/bi-form/bi-form.component';
import {AddressComponent} from './address/address.component';
import {ServicesComponent} from './services/services.component';
import {PersonalInfoComponent} from './personal-info/personal-info.component';
import {UploadPhotosComponent} from './upload-photos/upload-photos.component';
import {LoginFormComponent} from '../login-form/login-form.component';
import {EndOfRegistrationComponent} from './end-of-registration/end-of-registration.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {path: 'basic-info', component: BasicInfoComponent},
      {path: 'basic-info/bi-form', component: BiFormComponent},
      {path: 'address', component: AddressComponent},
      {path: 'services', component: ServicesComponent},
      {path: 'personal-info', component: PersonalInfoComponent},
      {path: 'upload-photos', component: UploadPhotosComponent},
      {path: 'login', component: LoginFormComponent},
      {path: 'end-of-registration', component: EndOfRegistrationComponent},
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class RegisterRoutingModule {
}
