import { NgModule } from '@angular/core';
import {ShortFormComponent} from './short-form.component';
import {MaterialModule} from '../../shared/material.module';
import {ReactiveFormsModule} from '@angular/forms';
import {ServicesPartModule} from '../services-part/services-part.module';


@NgModule({
  declarations: [ShortFormComponent],
  imports: [
    MaterialModule,
    ReactiveFormsModule,
    ServicesPartModule
  ],
  exports: [
    ShortFormComponent

  ]
})
export class ShortFormModule { }

