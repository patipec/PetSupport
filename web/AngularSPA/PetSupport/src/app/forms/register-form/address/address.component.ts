import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';
import { IAddress } from '../IRegistration-data';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent {

  address: IAddress;
  isFormValid: boolean;
   

    constructor(private http: HttpClient,
                private registrationService: RegistrationService) {
                }

    onFormChange(address: IAddress) {
      this.address = address;
    }

    onStatusChange(status: boolean) {
      this.isFormValid = status;
    }

    onSubmit(): void {
      console.log(this.address);
      console.log(this.isFormValid);
      if (this.isFormValid) {
        this.registrationService.setAddress(this.address);
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


