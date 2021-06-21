import {NgModule} from '@angular/core';
import {ServicesPartComponent} from './services-part.component';
import {ReactiveFormsModule} from '@angular/forms';
import {SharedModule} from '../../../modules/shared.module';
import {SingleServiceInputModule} from '../../atoms/single-service-input/single-service-input.module';


@NgModule({
  declarations: [ServicesPartComponent],
  imports: [SharedModule, ReactiveFormsModule, SingleServiceInputModule],
  exports: [ServicesPartComponent]
})
export class ServicesPartModule {}

