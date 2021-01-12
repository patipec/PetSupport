import {FormControl, FormGroup} from '@angular/forms';

export interface IRegistrationForm {
    name: string;
    surname: string;
    email: string;
    phone: string;
    password: string;
    repeatpassword: string;
    street: string;
    housenr: string;
    city: string;
    zipcode: string;
    country: string;
    //services
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
