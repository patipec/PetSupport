import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

interface RegisterData {
  name: string;
  surname: string;
  email: string;
  country: string;
  street: string;
  houseNb: string;
}

export class RegistrationService {

  registerData: RegisterData;
  constructor() { }

  //setProperty(key: string, value: string) {
  //  this.registerData[key] = value;
  //}

  setName(name: string): void {
    this.registerData.name = name;
  }

  setSurname(surname: string): void {
    this.registerData.surname = surname;
  }

  setStreet(surname: string): void {
    this.registerData.surname = surname;
  }

}
