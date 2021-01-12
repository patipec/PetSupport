import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IRegistrationForm } from './IRegistration-data';

@Injectable({
  providedIn: 'root'
})

export class RegistrationService {

  registerData: IRegistrationForm;
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
  setEmail(email: string): void {
    this.registerData.email = email;
  }
  setPhone(phone: string): void {
    this.registerData.phone = phone;
  }
  setPassword(password: string): void {
    this.registerData.password = password;
  }
  setRepeatPassword(repeatpassword: string): void {
    this.registerData.repeatpassword = repeatpassword;
  }


  setStreet(street: string): void {
    this.registerData.street = street;
  }
  setHouseNr(housenr: string): void {
    this.registerData.housenr = housenr;
  }
  setCity(city: string): void {
    this.registerData.city = city;
  }
  setZipcode(zipcode: string): void {
    this.registerData.zipcode = zipcode;
  }
  setCountry(country: string): void {
    this.registerData.country = country;
  }

  //services

  setBirthday(birthday: string): void {
    this.registerData.birthday = birthday;
  }
  setTitle(title: string): void {
    this.registerData.title = title;
  }
  setExperience(experience: string): void {
    this.registerData.experience = experience;
  }
  setAvailability(availability: string): void {
    this.registerData.availability = availability;
  }
  setEnvironment(environment: string): void {
    this.registerData.environment = environment;
  }


  http: HttpClient;

  saveUser(postData: {title: string; content: string}){
    //debuggerem sprawdzic czy zapisuja mi sie te dane 
    //wykorzystaj this.registerData ktore posiada wszystkie potrzebne informacje i przekazac ten obiekt caly do backendu
    
      this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json', 
      postData
        ).subscribe(responseData => {
          console.log(responseData);
        });
      
  }
  
}
