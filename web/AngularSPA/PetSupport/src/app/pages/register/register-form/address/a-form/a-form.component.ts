import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {FormBuilder} from '@angular/forms';
import {HttpClient} from '@angular/common/http';
import {IAddress} from '../../../../../common/models/IRegistration-data';
import {RegistrationService} from '../../../registration.service';
import {appValidators} from '../../../../../common/validators/validators';

@Component({
  selector: 'app-a-form',
  templateUrl: './a-form.component.html',
  styleUrls: ['./a-form.component.scss']
})
export class AFormComponent implements OnInit {

  GOOGLE_API = 'https://maps.googleapis.com/maps/api/geocode/json?';
  WOJTEK_GOOGLE_KEY = '';

  lat: number;
  lng: number;
  @Output()
  onFormChanged = new EventEmitter<IAddress>();

  @Output()
  formValid = new EventEmitter<boolean>();

  signupForm = this.fb.group({

    street: ['waww', appValidators.street],
    houseNr: ['1/ 2 a', appValidators.houseNr],
    city: ['asasasaa', appValidators.city],
    zipCode: ['12345', appValidators.zipCode],
    country: ['Poland', appValidators.country],
    coordinates: []
  });

  constructor(private http: HttpClient,
              private registrationService: RegistrationService,
              private fb: FormBuilder) {
  }

  ngOnInit(): void {
    this.signupForm.valueChanges.subscribe(value => {
      this.onFormChanged.emit(value);
    });
    this.signupForm.statusChanges.subscribe(status => this.formValid.emit(status === 'VALID'));
    this.getUserCurrentPostion();
  }

  getUserCurrentPostion(): void {
    navigator.geolocation.getCurrentPosition((position) => {
      this.lat = position.coords.latitude;
      this.lng = position.coords.longitude;
      console.log('Lat: ', position.coords.latitude, 'Lng: ', position.coords.longitude);
    });
  }

  convertAddressToQuery(): string {
    const zip = this.signupForm.get('zipCode').value;
    const street = this.signupForm.get('street').value;
    const housenr = this.signupForm.get('houseNr').value;
    const city = this.signupForm.get('city').value;
    return `address=${zip}+${street}+${housenr},+${city}`;
  }

  convertAddressToCords(): void {
    this.http.get(`${this.GOOGLE_API}${this.convertAddressToQuery()}${this.WOJTEK_GOOGLE_KEY}`)
      .subscribe((res: any) => {
        console.log(res);
      });
  }

}
