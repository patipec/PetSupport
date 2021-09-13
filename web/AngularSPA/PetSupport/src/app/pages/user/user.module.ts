import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MessagesListComponent} from './messages/messages-list/messages-list.component';
import {MessageComponent} from './messages/message/message.component';
import {MaterialModule} from '../../common/modules/material.module';
import {UserRoutingModule} from './user-routing.module';
import {HttpClientModule} from '@angular/common/http';
import {LoginAuthGuard} from '../../common/auth/login-guard';
import { UserWrapperComponent } from './user-wrapper/user-wrapper.component';
import { UserBasicInfoComponent } from './user-basic-info/user-basic-info.component';
import { UserAddressComponent } from './user-address/user-address.component';
import { UserServicesComponent } from './user-services/user-services.component';
import { UserPersonalInfoComponent } from './user-personal-info/user-personal-info.component';
import { UserPasswordComponent } from './user-password/user-password.component';
import { UserGalleryComponent } from './user-gallery/user-gallery.component';
import {SharedModule} from '../../common/modules/shared.module';
import {ReactiveFormsModule} from '@angular/forms';
import {SingleServiceInputModule} from '../../common/components/atoms/single-service-input/single-service-input.module';
import {DisableControlModule} from '../../common/directives/disable-control/disable-control.module';


@NgModule({
  declarations: [
    MessagesListComponent,
    MessageComponent,
    UserWrapperComponent,
    UserBasicInfoComponent,
    UserAddressComponent,
    UserServicesComponent,
    UserPersonalInfoComponent,
    UserPasswordComponent,
    UserGalleryComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    UserRoutingModule,
    HttpClientModule,
    SharedModule,
    ReactiveFormsModule,
    SingleServiceInputModule,
    DisableControlModule,
  ],
  providers: [
    LoginAuthGuard
  ],
  exports: []
})
export class UserModule {
}
