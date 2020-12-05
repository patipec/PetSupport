import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { HttpClientModule} from '@angular/common/http';
// import { FormGroup} from "@angular/forms";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MainPageComponent } from './main-page/main-page/main-page.component';
import { PettsitersComponent } from './petsitters/pettsiters/pettsiters.component';
import { ShortFormComponent } from './forms/short-form/short-form.component';
import { LongFormComponent } from './forms/long-form/long-form.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MaterialModule} from './shared/material.module';

@NgModule({
  declarations: [
    AppComponent,
    MainPageComponent,
    PettsitersComponent,
    ShortFormComponent,
    LongFormComponent,

  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    MaterialModule,
    BrowserAnimationsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
