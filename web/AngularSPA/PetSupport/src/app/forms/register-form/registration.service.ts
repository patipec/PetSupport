import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IAddress, IBasicInfo, IPersonalInfo, IRegistrationForm } from './IRegistration-data';

@Injectable({
  providedIn: 'root'
})

export class RegistrationService {

  registerData: IRegistrationForm = {
    basicInfo: {},
    address: {},
    personalInfo: {}
  };
  constructor(private http: HttpClient) {
  }

  setBasicInfo(basicInfo: IBasicInfo): void {
    console.log(basicInfo);
    this.registerData.basicInfo = basicInfo;
  }

  setAddress(address: IAddress): void {
    console.log(address);
    this.registerData.address = address;
  }

  setPersonalInfo(personalInfo: IPersonalInfo): void {
    console.log(personalInfo);
    this.registerData.personalInfo = personalInfo;
  }

  saveUser(): void{
      this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json', this.registerData)
        .subscribe(responseData => {
          console.log(responseData);
        });
  }
}