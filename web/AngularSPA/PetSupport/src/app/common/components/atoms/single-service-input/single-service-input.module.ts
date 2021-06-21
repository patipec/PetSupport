import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {SingleServiceInputComponent} from './single-service-input.component';
import {ReactiveFormsModule} from '@angular/forms';


@NgModule({
  declarations: [SingleServiceInputComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [
    SingleServiceInputComponent
  ]
})
export class SingleServiceInputModule {
}
