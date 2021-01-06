import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent {

    signupForm: FormGroup;
    
    ngOnInit() {
      this.signupForm = new FormGroup({
        'userData': new FormGroup({
            'street': new FormControl(null, [Validators.required,Validators.maxLength(25),Validators.minLength(3)]),
            'housenr': new FormControl(null, [Validators.required,Validators.maxLength(10),Validators.pattern('^[a-zA-Z0-9_.+-]+/[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')]),
            'city': new FormControl(null, [Validators.required,Validators.maxLength(30),Validators.minLength(3)]),
            'zipcode': new FormControl(null, Validators.required, this.forbiddenZipCode),
            'country': new FormControl('Poland', [Validators.required,Validators.maxLength(30),Validators.minLength(3)])
        }),
      });
    }

  //wersja wcześniejsza bez serwisu
        // constructor( private http: HttpClient) { }
        
        // onSubmit(){
        //   console.log(this.signupForm);
        // }
  //^^wersja wcześniejsza bez serwisu^^


      constructor( private http: HttpClient, private registrationService: RegistrationService) { }


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
      
      onSubmit(control) {
        console.log(this.signupForm);
        this.registrationService.setStreet(this.signupForm.controls['userData.street'].value);
        this.registrationService.setHouseNr(this.signupForm.controls['userData.housenr'].value);
        this.registrationService.setCity(this.signupForm.controls['userData.city'].value);
        this.registrationService.setZipcode(this.signupForm.controls['userData.zipcode'].value);
        this.registrationService.setCountry(this.signupForm.controls['userData.country'].value);
      }

      onCreatePost(postData: {title: string; content: string}) {
      this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json', 
      postData
        ).subscribe(responseData => {
          console.log(responseData);
        });
        this.signupForm.reset();
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

}
