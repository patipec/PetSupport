import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';
import {IAddress} from '../../IRegistration-data';
import {RegistrationService} from '../../registration.service';

@Component({
  selector: 'app-a-form',
  templateUrl: './a-form.component.html',
  styleUrls: ['./a-form.component.css']
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

    street: ['waww', [Validators.required, Validators.maxLength(25), Validators.minLength(3)]],
    housenr: ['1/2 a', [Validators.required, Validators.maxLength(10),
      Validators.pattern('^[a-zA-Z0-9_.+-]+/[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')]],
    city: ['asasasaa', [Validators.required, Validators.maxLength(30), Validators.minLength(3)]],
    zipcode: ['12345', Validators.required, this.forbiddenZipCode],
    country: ['Poland', [Validators.required, Validators.maxLength(30), Validators.minLength(3)]]


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

  forbiddenZipCode(control: FormControl): Promise<any> | Observable<any> {
    const promise = new Promise<any>((resolve, reject) => {
      setTimeout(() => {
        if (control.value === '00-000') {
          resolve({ZipCodeIsForbidden: true});
        }
        if (control.value === '00000') {
          resolve({ZipCodeIsForbidden: true});
        } else {
          resolve(null);
        }

      }, 1000);
    });
    return promise;
  }
  getUserCurrentPostion(): void {
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
    return `address=${zip}+${street}+${housenr},+${city}`;
  }

  convertAddressToCords(): void {
    this.http.get(`${this.GOOGLE_API}${this.convertAddressToQuery()}${this.WOJTEK_GOOGLE_KEY}`)
      .subscribe((res: any) => {
      console.log(res);
    });
  }

}
