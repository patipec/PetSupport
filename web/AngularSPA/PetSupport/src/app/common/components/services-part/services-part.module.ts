import {NgModule} from '@angular/core';
import {MaterialModule} from '../../shared/material.module';
import {ServicesPartComponent} from './services-part.component';
import {ReactiveFormsModule} from '@angular/forms';
import {CommonModule} from '@angular/common';


@NgModule({
  declarations: [ServicesPartComponent],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule
  ],
  exports: [
    ServicesPartComponent

  ]
})
export class ServicesPartModule {
}

