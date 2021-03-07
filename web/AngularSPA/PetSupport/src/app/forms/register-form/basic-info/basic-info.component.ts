import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';
import {IBasicInfo} from '../IRegistration-data';

@Component({
  selector: 'app-basic-info',
  templateUrl: './basic-info.component.html',
  styleUrls: ['./basic-info.component.scss']
})
export class BasicInfoComponent {
  hide = true;
  basicInfo: IBasicInfo;
  isFormValid: boolean;
  constructor(private http: HttpClient,
              private registrationService: RegistrationService) {}

  onFormChange(basicInfo: IBasicInfo): void {
    this.basicInfo = basicInfo;
  }
  onStatusChange(status: boolean): void {
    this.isFormValid = status;
  }
  onSubmit(): void {
    console.log(this.basicInfo);
    console.log(this.isFormValid);
    if (this.isFormValid) {
      this.registrationService.setBasicInfo(this.basicInfo);
    }
  }


}
