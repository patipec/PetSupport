import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {MessageComponent} from './messages/message/message.component';
import {LoginAuthGuard} from '../../common/auth/login-guard';
import {MessagesListComponent} from './messages/messages-list/messages-list.component';
import {UserWrapperComponent} from './user-wrapper/user-wrapper.component';
import {UserBasicInfoComponent} from './user-basic-info/user-basic-info.component';
import {UserAddressComponent} from './user-address/user-address.component';
import {UserServicesComponent} from './user-services/user-services.component';
import {UserPersonalInfoComponent} from './user-personal-info/user-personal-info.component';
import {UserGalleryComponent} from './user-gallery/user-gallery.component';
import {UserPasswordComponent} from './user-password/user-password.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: '',
        component: UserWrapperComponent,
        children: [
          {
            path: 'basic-info',
            component: UserBasicInfoComponent,
          },
          {
            path: 'address',
            component: UserAddressComponent,
          },
          {
            path: 'services',
            component: UserServicesComponent,
          },
          {
            path: 'personal-info',
            component: UserPersonalInfoComponent,
          },
          {
            path: 'gallery',
            component: UserGalleryComponent,
          },
          {
            path: 'password',
            component: UserPasswordComponent,
          },
        ]
      },
      {path: 'messages/:id', component: MessageComponent, canActivate: [LoginAuthGuard]},
      {path: 'messages', component: MessagesListComponent, canActivate: [LoginAuthGuard]},
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class UserRoutingModule {
}

