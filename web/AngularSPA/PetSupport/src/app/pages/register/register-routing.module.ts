import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {BasicInfoComponent} from './register-form/basic-info/basic-info.component';
import {BiFormComponent} from './register-form/basic-info/bi-form/bi-form.component';
import {AddressComponent} from './register-form/address/address.component';
import {ServicesComponent} from './register-form/services/services.component';
import {PersonalInfoComponent} from './register-form/personal-info/personal-info.component';
import {UploadPhotosComponent} from './register-form/upload-photos/upload-photos.component';
import {LoginFormComponent} from '../../common/components/login-form/login-form.component';
import {EndOfRegistrationComponent} from './register-form/end-of-registration/end-of-registration.component';

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
