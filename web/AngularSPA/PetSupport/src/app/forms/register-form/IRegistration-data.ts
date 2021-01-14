import {FormControl, FormGroup} from '@angular/forms';

export interface IRegistrationForm {
    basicInfo: IBasicInfo;
    address: IAddress;
    personalInfo: IPersonalInfo;
  }
  
  export interface IBasicInfo {
    name: string;
    surname: string;
    email: string;
    phone: string;
    password: string;
    repeatPassword: string;
  }
  
  export interface IAddress {
    street: string;
    housenr: string;
    city: string;
    zipcode: string;
    country: string;
  }
  
  export interface IPersonalInfo {
    birthday: string;
    title: string;
    experience: string;
    availability: string;
    environment: string;
  }

// range: new FormGroup({
//   start: new FormControl(),
//   end: new FormControl()
// })
