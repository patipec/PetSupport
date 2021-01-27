import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, NgForm} from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import {RegistrationService} from '../registration.service';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent {

  public signupForm: FormGroup;

  constructor(private http: HttpClient,
              private registrationService: RegistrationService) {
  }

  onSubmit(): void {
    this.registrationService.setServices(this.signupForm.value);
  }
}


