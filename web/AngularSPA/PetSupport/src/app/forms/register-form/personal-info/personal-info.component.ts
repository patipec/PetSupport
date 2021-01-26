import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';
import { IPersonalInfo } from '../IRegistration-data';

@Component({
  selector: 'app-personal-info',
  templateUrl: './personal-info.component.html',
  styleUrls: ['./personal-info.component.css']
})


export class PersonalInfoComponent {

  personalInfo: IPersonalInfo;
  isFormValid: boolean;

    constructor( private http: HttpClient,
                private registrationService: RegistrationService ) { }
    
      
  onFormChange(personalInfo: IPersonalInfo) {
    this.personalInfo = personalInfo;
  }

  onStatusChange(status: boolean) {
    this.isFormValid = status;
  }

  onSubmit(): void {
    console.log(this.personalInfo);
    console.log(this.isFormValid);
    if (this.isFormValid) {
      this.registrationService.setPersonalInfo(this.personalInfo);
    }
  }

}