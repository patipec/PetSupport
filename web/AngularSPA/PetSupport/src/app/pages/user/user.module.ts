import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {MessagesListComponent} from './messages/messages-list/messages-list.component';
import {MessageComponent} from './messages/message/message.component';
import {MaterialModule} from '../../common/modules/material.module';
import {UserRoutingModule} from './user-routing.module';
import {HttpClientModule} from '@angular/common/http';
import {LoginAuthGuard} from '../../common/auth/login-guard';


@NgModule({
  declarations: [
    MessagesListComponent,
    MessageComponent,
  ],
  imports: [
    CommonModule,
    MaterialModule,
    UserRoutingModule,
    HttpClientModule,
  ],
  providers: [
    LoginAuthGuard
  ],
  exports: []
})
export class UserModule {
}
