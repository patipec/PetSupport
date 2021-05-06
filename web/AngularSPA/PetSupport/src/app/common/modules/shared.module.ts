import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import {ButtonModule} from '../components/atoms/button/button.module';
import {FormFieldModule} from '../components/molecules/form-field/form-field.module';
import {ErrorTailorModule} from '@ngneat/error-tailor';

@NgModule({
  imports:      [],
  declarations: [],
  exports:      [ CommonModule, ButtonModule, FormFieldModule, ErrorTailorModule ]
})
export class SharedModule { }
