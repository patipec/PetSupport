import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
// import { HttpClientModule } from '@angular/common/http';
// import { FormGroup} from "@angular/forms";

import {HttpClientModule} from '@angular/common/http';
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
import {PettsitersComponent} from './petsitters/pettsiters/pettsiters.component';
import {ShortFormComponent} from './forms/short-form/short-form.component';
import {LongFormComponent} from './forms/long-form/long-form.component';
import {MaterialModule} from './shared/material.module';
import {MainNavComponent} from './main-nav/main-nav.component';
import {LayoutModule} from '@angular/cdk/layout';
import {BecomePetsitterComponent} from './become-petsitter/become-petsitter.component';
import { YellowWavesComponent } from './common/decorations/yellow-waves/yellow-waves.component';
import { NgxSliderModule } from '@angular-slider/ngx-slider';
import { RangeSlider } from './forms/shared/slider/slider.component';

@NgModule({
  declarations: [
    AppComponent,
    MainPageComponent,
    PettsitersComponent,
    ShortFormComponent,
    LongFormComponent,
    MainNavComponent,
    BecomePetsitterComponent,
    YellowWavesComponent,
    RangeSlider
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
    NgxSliderModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
