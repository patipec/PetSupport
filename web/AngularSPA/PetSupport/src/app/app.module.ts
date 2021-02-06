import {BrowserModule} from '@angular/platform-browser';
import {NgModule, CUSTOM_ELEMENTS_SCHEMA} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';


import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import {MatButtonModule} from '@angular/material/button';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatDividerModule} from '@angular/material/divider';
import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {MainPageComponent} from './pages/main-page/main-page.component';
import {ShortFormComponent} from './forms/short-form/short-form.component';
import {LongFormComponent} from './forms/long-form/long-form.component';
import {MaterialModule} from './common/shared/material.module';
import {MainNavComponent} from './common/components/main-nav/main-nav.component';
import {LayoutModule} from '@angular/cdk/layout';
import {BecomePetsitterComponent} from './pages/become-petsitter/become-petsitter.component';
import {YellowWavesComponent} from './common/decorations/yellow-waves/yellow-waves.component';
import {PetsitterComponent} from './pages/petsitters/petsitter/petsitter.component';
import {PetsittersListComponent} from './pages/petsitters/petsitters-list/petsitters-list.component';
import {PetsitterListTileComponent} from './pages/petsitters/petsitters-list/petsitter-list-tile/petsitter-list-tile.component';
import {PettsittersComponent} from './pages/petsitters/pettsiters/pettsiters.component';
import {BasicInfoComponent} from './forms/register-form/basic-info/basic-info.component';
import {AddressComponent} from './forms/register-form/address/address.component';
import {ServicesComponent} from './forms/register-form/services/services.component';
import {PersonalInfoComponent} from './forms/register-form/personal-info/personal-info.component';
import {EndOfRegistrationComponent} from './forms/register-form/end-of-registration/end-of-registration.component';
import {FooterComponent} from './common/components/footer/footer.component';
import {MatCarouselModule} from '@ngmodule/material-carousel';
import {CardCaruselComponent} from './pages/main-page/card-carusel/card-carusel.component';
import {ServicesCardsComponent} from './pages/main-page/services-cards/services-cards.component';
import {NgxSliderModule} from '@angular-slider/ngx-slider';
import {RangeSlider} from './forms/shared/slider/slider.component';
import {MapComponent} from './common/components/map/map.component';
import {LoginFormComponent} from './forms/login-form/login-form.component';

import {RateComponent} from './common/shared/rate/rate.component';
import {IvyCarouselModule} from 'angular-responsive-carousel';
import {PetsitterServicesComponent} from './pages/petsitters/petsitter/petsitter-services/petsitter-services.component';
import {PetsitterCalendarComponent} from './pages/petsitters/petsitter/petsitter-calendar/petsitter-calendar.component';
import {PetsitterReviewsComponent} from './pages/petsitters/petsitter/petsitter-reviews/petsitter-reviews.component';
import {PetsitterCanHostComponent} from './pages/petsitters/petsitter/petsitter-can-host/petsitter-can-host.component';
import {ContactFormComponent} from './pages/contact-form/contact-form.component';
import {ContactFormSuccessComponent} from './pages/contact-form/contact-form-success/contact-form-success.component';
import {EditProfileComponent} from './pages/edit-profile/edit-profile.component';
import {BiFormComponent} from './forms/register-form/basic-info/bi-form/bi-form.component';
import {UploadPhotosComponent} from './forms/register-form/upload-photos/upload-photos.component';
import {ServicesPartComponent} from './forms/services-part/services-part.component';
// @ts-ignore
import {clientId, authority, redirectUri, postLogoutRedirectUri} from './auth.json';
import {FullCalendarModule} from '@fullcalendar/angular'; // the main connector. must go first
import dayGridPlugin from '@fullcalendar/daygrid'; // a plugin
import interactionPlugin from '@fullcalendar/interaction';
import {CustomSliderComponent} from './pages/petsitters/petsitter/custom-slider/custom-slider.component';
import {PhotoGalleryComponent} from './forms/register-form/upload-photos/photo-gallery/photo-gallery.component';
import {AFormComponent} from './forms/register-form/address/a-form/a-form.component';
import {PiFormComponent} from './forms/register-form/personal-info/pi-form/pi-form.component';
import {SFormComponent} from './forms/register-form/services/s-form/s-form.component';

const isIE = window.navigator.userAgent.indexOf('MSIE ') > -1 || window.navigator.userAgent.indexOf('Trident/') > -1;

FullCalendarModule.registerPlugins([ // register FullCalendar plugins
  dayGridPlugin,
  interactionPlugin
]);

import {AngularFileUploaderModule} from 'angular-file-uploader';
import {MsalModule, MsalInterceptor} from '@azure/msal-angular';
import {AuthButtonComponent} from './common/auth/auth-button/auth-button.component';

@NgModule({
  declarations: [
    AppComponent,
    MainPageComponent,
    ShortFormComponent,
    LongFormComponent,
    MainNavComponent,
    BecomePetsitterComponent,
    YellowWavesComponent,
    PetsitterComponent,
    PetsittersListComponent,
    PetsitterListTileComponent,
    PettsittersComponent,
    BasicInfoComponent,
    AddressComponent,
    ServicesComponent,
    PersonalInfoComponent,
    FooterComponent,
    CardCaruselComponent,
    ServicesCardsComponent,
    RangeSlider,
    MapComponent,
    LoginFormComponent,
    RateComponent,
    PetsitterServicesComponent,
    PetsitterCalendarComponent,
    PetsitterReviewsComponent,
    PetsitterCanHostComponent,
    ContactFormComponent,
    ContactFormSuccessComponent,
    EndOfRegistrationComponent,
    EditProfileComponent,
    BiFormComponent,
    UploadPhotosComponent,
    ServicesPartComponent,
    CustomSliderComponent,
    PhotoGalleryComponent,
    AFormComponent,
    PiFormComponent,
    SFormComponent,
    AuthButtonComponent,
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatButtonModule,
    MatIconModule,
    LayoutModule,
    MatDividerModule,
    MatGridListModule,
    FormsModule,
    MaterialModule,
    ReactiveFormsModule,
    MatCarouselModule.forRoot(),
    NgxSliderModule,
    IvyCarouselModule,
    FullCalendarModule,
    BrowserModule,
    AngularFileUploaderModule,
    MsalModule.forRoot({
      auth: {
        clientId,
        authority,
        redirectUri,
        postLogoutRedirectUri
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
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
