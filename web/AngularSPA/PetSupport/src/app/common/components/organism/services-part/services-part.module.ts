import {NgModule} from '@angular/core';
import {ServicesPartComponent} from './services-part.component';
import {ReactiveFormsModule} from '@angular/forms';
import {SharedModule} from '../../../modules/shared.module';
import { SingleServiceInputComponent } from './single-service-input/single-service-input.component';


@NgModule({
  declarations: [ServicesPartComponent, SingleServiceInputComponent],
  imports: [SharedModule, ReactiveFormsModule],
  exports: [ServicesPartComponent]
})
export class ServicesPartModule {}

