import {BrowserModule} from '@angular/platform-browser';
import {NgModule, CUSTOM_ELEMENTS_SCHEMA} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';


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
import {MainPageComponent} from './main-page/main-page.component';
import {ShortFormComponent} from './forms/short-form/short-form.component';
import {LongFormComponent} from './forms/long-form/long-form.component';
import {MaterialModule} from './shared/material.module';
import {MainNavComponent} from './main-nav/main-nav.component';
import {LayoutModule} from '@angular/cdk/layout';
import {BecomePetsitterComponent} from './become-petsitter/become-petsitter.component';
import { YellowWavesComponent } from './common/decorations/yellow-waves/yellow-waves.component';
import { PetsitterComponent } from './petsitters/petsitter/petsitter.component';
import { PetsittersListComponent } from './petsitters/petsitters-list/petsitters-list.component';
import { PetsitterListTileComponent } from './petsitters/petsitters-list/petsitter-list-tile/petsitter-list-tile.component';
import {PettsittersComponent} from './petsitters/pettsiters/pettsiters.component';
import { BasicInfoComponent } from './register-form/basic-info/basic-info.component';
import { AddressComponent } from './register-form/address/address.component';
import { ServicesComponent } from './register-form/services/services.component';
import { PersonalInfoComponent } from './register-form/personal-info/personal-info.component';
import { FooterComponent } from './footer/footer.component';
import { MatCarouselModule } from '@ngmodule/material-carousel';
import { CardCaruselComponent } from './main-page/card-carusel/card-carusel.component';
import { ServicesCardsComponent } from './main-page/services-cards/services-cards.component';
import { NgxSliderModule } from '@angular-slider/ngx-slider';
import { RangeSlider } from './forms/shared/slider/slider.component';
import { MapComponent } from './map/map.component';
import { LoginFormComponent } from './forms/login-form/login-form.component';


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
    LoginFormComponent
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
    NgxSliderModule
  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
