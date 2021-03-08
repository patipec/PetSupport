import {BrowserModule} from '@angular/platform-browser';
import {NgModule, CUSTOM_ELEMENTS_SCHEMA} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {MainPageComponent} from './pages/main-page/main-page.component';
import {MaterialModule} from './common/modules/material.module';
import {MainNavComponent} from './common/components/main-nav/main-nav.component';
import {LayoutModule} from '@angular/cdk/layout';
import {BecomePetsitterComponent} from './pages/become-petsitter/become-petsitter.component';
import {YellowWavesComponent} from './common/styles/decorations/yellow-waves/yellow-waves.component';
import {FooterComponent} from './common/components/footer/footer.component';
import {MatCarouselModule} from '@ngmodule/material-carousel';
import {CardCaruselComponent} from './pages/main-page/card-carusel/card-carusel.component';
import {ServicesCardsComponent} from './pages/main-page/services-cards/services-cards.component';
import {LoginFormComponent} from './common/components/login-form/login-form.component';
import {ContactFormComponent} from './pages/contact-form/contact-form.component';
import {ContactFormSuccessComponent} from './pages/contact-form/contact-form-success/contact-form-success.component';
import {EditProfileComponent} from './pages/edit-profile/edit-profile.component';
import {MsalModule, MsalInterceptor} from '@azure/msal-angular';
import {AuthButtonComponent} from './common/auth/auth-button/auth-button.component';
import {LoginAuthGuard} from './common/auth/login-guard';
import {NotAuthorizedComponent} from './common/auth/not-authorized/not-authorized.component';
import {ShortFormModule} from './common/components/short-form/short-form.module';



// @ts-ignore
import {clientId, authority, redirectUri, postLogoutRedirectUri} from './auth.json';
const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    MainNavComponent,
    MainPageComponent,
    YellowWavesComponent,
    CardCaruselComponent,
    ServicesCardsComponent,
    BecomePetsitterComponent,

    /*Auth module*/
    LoginFormComponent,
    AuthButtonComponent,
    NotAuthorizedComponent,
    /*Probably user module*/
    EditProfileComponent,

    ContactFormComponent,
    ContactFormSuccessComponent,

  ],

  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    BrowserModule,
    AppRoutingModule,
    LayoutModule,
    MaterialModule,
    ShortFormModule,
    MatCarouselModule,
    MsalModule.forRoot({
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
    }, {
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
    })


  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: MsalInterceptor,
      multi: true
    },
    LoginAuthGuard
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
