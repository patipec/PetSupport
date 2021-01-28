import {FormControl, FormGroup} from '@angular/forms';
export interface IBasicInfo {
    name: string;
    surname: string;
    email: string;
    phone: string;
    password: string;
    confirmPassword: string;
}
export interface IAddress {
    street: string;
    housenr: string;
    city: string;
    zipcode: string;
    country: string;
    coordinates: [];
}
export interface IPersonalInfo {
    birthday: string;
    title: string;
    experience: string;
    availability: string;
    environment: string;
}
export interface IRegistrationForm {
    basicInfo: IBasicInfo;
    address: IAddress;
    personalInfo: IPersonalInfo;
    services: IPetsitterServices;
}

export interface IPetsitterServices {
  service: string;
  petPreferences: {
    dog: string | null;
    cat: string | null;
    other: string | null;
  };
}
// this.services = this.fb.group({
//   service: 'boarding',
//   extraServices: this.fb.group( {
//     dog: false,
//     cat: false,
//     other: false
//   })

// range: new FormGroup({
//   start: new FormControl(),
//   end: new FormControl()
// })
