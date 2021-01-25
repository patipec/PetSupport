import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, NgForm} from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import {RegistrationService} from '../registration.service';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  public signupForm: FormGroup;

  constructor(private fb: FormBuilder,
              private http: HttpClient,
              private registrationService: RegistrationService) {
  }
  ngOnInit(): void {
    this.signupForm = this.fb.group({
      service: 'boarding',
      petPreferences: this.fb.group( {
        dog: false,
        cat: false,
        other: false
      })
      });
    }
    onExtraServiceClick(service: string): void{
      const extra = this.signupForm.get(`petPreferences.${service}`);
      extra.setValue(!extra.value);
      const elem = document.getElementById(`_${service}`);
      if (extra.value){
        elem.style.backgroundColor = 'rgb(254, 203, 64)';
      }else{
        elem.style.backgroundColor = 'white';
      }
    }

  onSubmit(): void {

    this.registrationService.setServices(this.signupForm.value);

  }
}


