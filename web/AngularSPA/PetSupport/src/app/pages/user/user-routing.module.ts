import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {MessageComponent} from './messages/message/message.component';
import {LoginAuthGuard} from '../../common/auth/login-guard';
import {MessagesListComponent} from './messages/messages-list/messages-list.component';

const routes: Routes = [
  {
    path: '',
    children: [
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

