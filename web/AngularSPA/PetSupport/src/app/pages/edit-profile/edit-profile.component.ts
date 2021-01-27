import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IAddress, IBasicInfo, IPersonalInfo } from 'src/app/forms/register-form/IRegistration-data';
import { RegistrationService } from 'src/app/forms/register-form/registration.service';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
})
export class EditProfileComponent {

  constructor(private http: HttpClient,
                private registrationService: RegistrationService) {
                }

  basicInfo: IBasicInfo;
  address: IAddress;
  personalInfo: IPersonalInfo;

  isFormValid1: boolean;
  isFormValid2: boolean;
  isFormValid4: boolean;

  display1 = false;
  display2 = false;
  display3 = false;
  display4 = false;

  onPressBasicInfo() {
    this.display1 = true;
    this.display2 = false;
    this.display3 = false;
    this.display4 = false;
    //To toggle the component
    //this.display = !this.display;
  }

  onPressAddress() {
    this.display2 = true;
    this.display1 = false;
    this.display3 = false;
    this.display4 = false;
  }

  onPressServices() {
    this.display3 = true;
    this.display1 = false;
    this.display2 = false;
    this.display4 = false;
  }

  onPressPersonalInfo() {
    this.display4 = true;
    this.display1 = false;
    this.display3 = false;
    this.display2 = false;
  }

  onFormChange1(basicInfo: IBasicInfo) {
    this.basicInfo = basicInfo;
  }
  onFormChange2(address: IAddress) {
    this.address = address;
  }
  onFormChange4(personalInfo: IPersonalInfo) {
    this.personalInfo = personalInfo;
  }

  onStatusChange1(status: boolean) {
    this.isFormValid1 = status;
  }
  onStatusChange2(status: boolean) {
    this.isFormValid2 = status;
  }
  onStatusChange4(status: boolean) {
    this.isFormValid4 = status;
  }

  onSubmit1(): void {
    console.log(this.basicInfo);
    console.log(this.isFormValid1);
    if (this.isFormValid1) {
      this.registrationService.setBasicInfo(this.basicInfo);
    }
  }
  onSubmit2(): void {
    console.log(this.address);
    console.log(this.isFormValid2);
    if (this.isFormValid2) {
      this.registrationService.setAddress(this.address);
    }
  }
  onSubmit4(): void {
    console.log(this.personalInfo);
    console.log(this.isFormValid4);
    if (this.isFormValid4) {
      this.registrationService.setPersonalInfo(this.personalInfo);
    }
  }
  
}
