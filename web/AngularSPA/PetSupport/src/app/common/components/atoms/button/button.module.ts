import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {ButtonComponent} from './button.component';
import { ButtonIconComponent } from './button-icon/button-icon/button-icon.component';



@NgModule({
  declarations: [ButtonComponent, ButtonIconComponent],
  exports: [
    ButtonComponent, ButtonIconComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ButtonModule { }
