import {Component, OnInit} from '@angular/core';
import {BroadcastService, MsalService} from '@azure/msal-angular';
import {AuthService} from '../auth.service';

@Component({
  selector: 'app-auth-button',
  templateUrl: './auth-button.component.html',
  styleUrls: ['./auth-button.component.scss']
})
export class AuthButtonComponent implements OnInit {

  constructor(private broadcastService: BroadcastService, private authService: MsalService, private myAuthService: AuthService) {
  }

  ngOnInit(): void {
  }

  public auth(): void {
    if (this.isLogged()) {
      this.authService.logout();
    } else {
      this.login();
    }
  }

  public login(): void {
    const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;
    if (isIE) {
      this.authService.loginRedirect({
        extraScopesToConsent: ['user.read', 'openid', 'profile']
      });
    } else {
      this.authService.loginPopup({
        extraScopesToConsent: ['user.read', 'openid', 'profile']
      });
    }
  }

  public isLogged(): boolean {
    return this.myAuthService.isLogged();
  }
}

