import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent {


    signupForm = this.fb.group({
          'street': ['', [Validators.required,Validators.maxLength(25),Validators.minLength(3)]],
          'housenr': ['', [Validators.required,Validators.maxLength(10),Validators.pattern('^[a-zA-Z0-9_.+-]+/[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')]],
          'city': ['', [Validators.required,Validators.maxLength(30),Validators.minLength(3)]],
          'zipcode': ['', Validators.required, this.forbiddenZipCode],
          'country': ['Poland', [Validators.required,Validators.maxLength(30),Validators.minLength(3)]]

    });
  
    constructor(private http: HttpClient,
      private registrationService: RegistrationService,
      private fb: FormBuilder) {}


    forbiddenZipCode(control: FormControl): Promise<any> | Observable<any> {
      const promise = new Promise<any>((resolve, reject) => {
        setTimeout(() => {
          if (control.value === '00-000') {
            resolve({'ZipCodeIsForbidden': true});
          } 
          if (control.value === '00000') {
            resolve({'ZipCodeIsForbidden': true});
          } 
          else {
            resolve(null);
          }
          
        }, 1000);
      });
      return promise;
    }
    
    onSubmit(): void {
      console.log(this.signupForm);
      //this.registrationService.setAddress(this.signupForm.value);
      //this.registrationService.saveUser();
      if (this.signupForm.status === 'VALID'){
        this.registrationService.setAddress(this.signupForm.value);
      }
      else {
        this.signupForm.get('street').markAsTouched();
        this.signupForm.get('housenr').markAsTouched();
        this.signupForm.get('city').markAsTouched();
        this.signupForm.get('zipcode').markAsTouched();
        this.signupForm.get('country').markAsTouched();
      }
    }

  }

//wiadomosci wyswietlane przy errorach ( ktore nie za jeszcze zaimplementowane do kodu html)
    // validation_messages = {
    //     'street': [
    //       { type: 'required', message: 'Street is required' },
    //       { type: 'minlength', message: 'Street must be at least 3 characters long' },
    //       { type: 'maxlength', message: 'Street cannot be more than 25 characters long' },
    //       ],
    //     'housenr': [
    //       { type: 'required', message: 'House number is required' },
    //       { type: 'maxlength', message: 'House number cannot be more than 10 characters long' },
    //     ],
    //     'city': [
    //       { type: 'required', message: 'City is required' },
    //       { type: 'minlength', message: 'Street must be at least 3 characters long' },
    //       { type: 'maxlength', message: 'City cannot be more than 30 characters long' }
    //     ],
    //     'zipcode': [
    //       { type: 'required', message: 'Zip Code is required' },
    //       { type: 'forbiddenZipCode', message: 'Zip Code must be at least 5 characters long' },
    //       ],
    //     'country': [
    //       { type: 'required', message: 'Country is required' },
    //       { type: 'minlength', message: 'Country must be at least 3 characters long' },
    //       { type: 'maxlength', message: 'Country cannot be more than 30 characters long' }
    //     ]
    //   }


