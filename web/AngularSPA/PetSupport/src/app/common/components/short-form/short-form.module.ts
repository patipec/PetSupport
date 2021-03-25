import { NgModule } from '@angular/core';
import {ShortFormComponent} from './short-form.component';
import {MaterialModule} from '../../modules/material.module';
import {ReactiveFormsModule} from '@angular/forms';
import {ServicesPartModule} from '../services-part/services-part.module';
import {CommonModule} from '@angular/common';


@NgModule({
  declarations: [ShortFormComponent],
  imports: [
    CommonModule,
    MaterialModule,
    ReactiveFormsModule,
    ServicesPartModule
  ],
  exports: [
    ShortFormComponent

  ]
})
export class ShortFormModule { }

