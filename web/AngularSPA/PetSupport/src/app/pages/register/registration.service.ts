import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IAddress, IBasicInfo, IPersonalInfo,
         IRegistrationForm, IPetsitterServices } from '../../common/models/old-models/IRegistration-data';

@Injectable({
  providedIn: 'root'
})

export class RegistrationService {

  registerData: IRegistrationForm = {
    basicInfo: {} as IBasicInfo,
    address: {} as IAddress,
    personalInfo: {} as IPersonalInfo,
    services: {} as IPetsitterServices
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
  setServices(services: IPetsitterServices): void{
    console.log(services);
    this.registerData.services = services;
  }

  saveUser(): void {
    this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json', this.registerData)
      .subscribe(responseData => {
        console.log(responseData);
      });
  }
}
