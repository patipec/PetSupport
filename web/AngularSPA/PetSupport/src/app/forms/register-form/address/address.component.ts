import {Component, OnInit} from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { RegistrationService } from '../registration.service';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent implements OnInit{

  GOOGLE_API = 'https://maps.googleapis.com/maps/api/geocode/json?';
  WOJTEK_GOOGLE_KEY = '';

  lat: number;
  lng: number;

  signupForm = this.fb.group({

          street: ['waww', [Validators.required, Validators.maxLength(25), Validators.minLength(3)]],
          housenr: ['1/2 a', [Validators.required, Validators.maxLength(10)]],
          city: ['asasasaa', [Validators.required, Validators.maxLength(30), Validators.minLength(3)]],
          zipcode: ['12345', Validators.required, this.forbiddenZipCode],
          country: ['Poland', [Validators.required, Validators.maxLength(30), Validators.minLength(3)]],
          coordinates: [[0, 0]]

    });

    constructor(private http: HttpClient,
                private registrationService: RegistrationService,
                private fb: FormBuilder) {
    }

     ngOnInit(): void {
       this.getUserCurrentPostion();
    }



  forbiddenZipCode(control: FormControl): Promise<any> | Observable<any> {
      const promise = new Promise<any>((resolve, reject) => {
        setTimeout(() => {
          if (control.value === '00-000') {
            resolve({ZipCodeIsForbidden: true});
          }
          if (control.value === '00000') {
            resolve({ZipCodeIsForbidden: true});
          }
          else {
            resolve(null);
          }

        }, 1000);
      });
      return promise;
    }

    getUserCurrentPostion(): void{
      navigator.geolocation.getCurrentPosition((position) => {
        this.lat = position.coords.latitude;
        this.lng = position.coords.longitude;
        console.log('Lat: ', position.coords.latitude, 'Lng: ', position.coords.longitude);
      });
    }

    convertAddressToQuery(): string {
      const zip = this.signupForm.get('zipcode').value;
      const street = this.signupForm.get('street').value;
      const housenr = this.signupForm.get('housenr').value;
      const city = this.signupForm.get('city').value;
      // console.log(zip);
      // console.log(street);
      // console.log(housenr);
      // console.log(city);
      // console.log(`address=${zip}+${street}+${housenr},+${city}`);
      return `address=${zip}+${street}+${housenr},+${city}`;
    // zip + street + city + state
    }

    convertAddressToCords(): void {
      this.http.get(`${this.GOOGLE_API}${this.convertAddressToQuery()}${this.WOJTEK_GOOGLE_KEY}`).subscribe((res: any) => {
        console.log(res);
      });
    }
    // patchCoordsOnSubmit(): void{
    //
    // }
    onSubmit(): void {
      // this.convertAddressToQuery();
      console.log('to tutaj', this.convertAddressToCords());
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


