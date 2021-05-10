import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {LabelDirective} from './label/label.directive';
import {InputDirective} from './input/input.directive';
import { FormFieldComponent } from './form-field/form-field.component';
import { InputErrorComponent } from './input-error/input-error.component';



@NgModule({
  declarations: [LabelDirective, InputDirective, FormFieldComponent, InputErrorComponent],
  exports: [
    FormFieldComponent,
    InputDirective,
    LabelDirective,
    InputErrorComponent
  ],
  imports: [
    CommonModule
  ]
})
export class FormFieldModule { }
