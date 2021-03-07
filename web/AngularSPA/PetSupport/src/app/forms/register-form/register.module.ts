import {NgModule} from '@angular/core';
import {BasicInfoComponent} from './basic-info/basic-info.component';
import {AddressComponent} from './address/address.component';
import {ServicesComponent} from './services/services.component';
import {PersonalInfoComponent} from './personal-info/personal-info.component';
import {AFormComponent} from './address/a-form/a-form.component';
import {SFormComponent} from './services/s-form/s-form.component';
import {PiFormComponent} from './personal-info/pi-form/pi-form.component';
import {BiFormComponent} from './basic-info/bi-form/bi-form.component';
import {PhotoGalleryComponent} from './upload-photos/photo-gallery/photo-gallery.component';
import {EndOfRegistrationComponent} from './end-of-registration/end-of-registration.component';
import {UploadPhotosComponent} from './upload-photos/upload-photos.component';
import {MaterialModule} from '../../common/shared/material.module';
import {RegisterRoutingModule} from './register-routing.module';
import {ReactiveFormsModule} from '@angular/forms';
import {AngularFileUploaderModule} from 'angular-file-uploader';
import {ServicesPartComponent} from '../services-part/services-part.component';
import {CommonModule} from '@angular/common';

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
    ServicesPartComponent

  ],
  imports: [
    MaterialModule,
    RegisterRoutingModule,
    ReactiveFormsModule,
    AngularFileUploaderModule,
    AngularFileUploaderModule,
    CommonModule,

  ],
})
export class RegisterModule {
}
