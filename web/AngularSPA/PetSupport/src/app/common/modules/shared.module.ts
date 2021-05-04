import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import {ButtonModule} from '../components/atoms/button/button.module';
import {FormFieldModule} from '../components/molecules/form-field/form-field.module';

@NgModule({
  imports:      [],
  declarations: [],
  exports:      [ CommonModule, ButtonModule, FormFieldModule ]
})
export class SharedModule { }
