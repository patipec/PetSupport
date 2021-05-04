/* Not ready yet */

import {MsalInterceptor, MsalModule} from '@azure/msal-angular';
import {HTTP_INTERCEPTORS} from '@angular/common/http';
// @ts-ignore
import {clientId, authority, redirectUri, postLogoutRedirectUri} from '../auth.json';

const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;


export const authProviders = [
  {
    provide: MsalModule,
    useValue: {
      auth: {
        clientId,
        authority,
        redirectUri,
        postLogoutRedirectUri,
        validateAuthority: false
      },
      cache: {
        cacheLocation: 'localStorage',
        storeAuthStateInCookie: isIE, // Set to true for Internet Explorer 11
      },
      popUp: !isIE,
      consentScopes: [
        'user.read',
        'openid',
        'profile',
      ],
      unprotectedResources: [],
      protectedResourceMap: [
        ['https://graph.microsoft.com/v1.0/me', ['user.read']]
      ],
      extraQueryParameters: {}
    },
  },
  {
    provide: HTTP_INTERCEPTORS,
    useClass: MsalInterceptor,
    multi: true
  }
];


