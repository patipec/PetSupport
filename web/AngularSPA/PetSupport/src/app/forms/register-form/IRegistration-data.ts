import {FormControl, FormGroup} from '@angular/forms';

export class RegistrationForm {
    //basic-info
    name: string;
    surname: string;
    email: string;
    phone: string;
    password: string;
    repeatpassword: string;
    //address
    street: string;
    housenr: string;
    city: string;
    zipcode: string;
    country: string;
  
    //services
  
    //personal-info
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
