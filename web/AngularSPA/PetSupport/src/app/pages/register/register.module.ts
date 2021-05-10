import {NgModule} from '@angular/core';
import {BasicInfoComponent} from './register-form/basic-info/basic-info.component';
import {AddressComponent} from './register-form/address/address.component';
import {ServicesComponent} from './register-form/services/services.component';
import {PersonalInfoComponent} from './register-form/personal-info/personal-info.component';
import {AFormComponent} from './register-form/address/a-form/a-form.component';
import {SFormComponent} from './register-form/services/s-form/s-form.component';
import {PiFormComponent} from './register-form/personal-info/pi-form/pi-form.component';
import {BiFormComponent} from './register-form/basic-info/bi-form/bi-form.component';
import {PhotoGalleryComponent} from './register-form/upload-photos/photo-gallery/photo-gallery.component';
import {EndOfRegistrationComponent} from './register-form/end-of-registration/end-of-registration.component';
import {UploadPhotosComponent} from './register-form/upload-photos/upload-photos.component';
import {MaterialModule} from '../../common/modules/material.module';
import {RegisterRoutingModule} from './register-routing.module';
import {ReactiveFormsModule} from '@angular/forms';
import {AngularFileUploaderModule} from 'angular-file-uploader';
import {CommonModule} from '@angular/common';
import {ServicesPartModule} from '../../common/components/organism/services-part/services-part.module';
import {SharedModule} from '../../common/modules/shared.module';

@NgModule({
  declarations: [
    BasicInfoComponent,
    AddressComponent,
    ServicesComponent,
    PersonalInfoComponent,
    EndOfRegistrationComponent,
    UploadPhotosComponent,
    PhotoGalleryComponent,
    BiFormComponent,
    AFormComponent,
    PiFormComponent,
    SFormComponent,

  ],
  imports: [
    MaterialModule,
    RegisterRoutingModule,
    ReactiveFormsModule,
    AngularFileUploaderModule,
    CommonModule,
    ServicesPartModule,
    SharedModule

  ],
  exports: [
    BiFormComponent,
    AFormComponent,
    SFormComponent,
    SFormComponent,
    PiFormComponent
  ]
})
export class RegisterModule {
}
