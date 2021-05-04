import {NgModule} from '@angular/core';
import {ServicesPartComponent} from './services-part.component';
import {ReactiveFormsModule} from '@angular/forms';
import {SharedModule} from '../../../modules/shared.module';


@NgModule({
  declarations: [ServicesPartComponent],
  imports: [SharedModule, ReactiveFormsModule],
  exports: [ServicesPartComponent]
})
export class ServicesPartModule {}

