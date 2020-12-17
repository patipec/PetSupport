import { Component, OnInit } from '@angular/core';
import { FormGroup, NgForm } from '@angular/forms';
import { Observable } from 'rxjs';
import { IRegistrationForm } from '../IRegistration-data';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  signupForm: IRegistrationForm = {
    service: '',
    typePet: '',
  };

  servicesTypes$: Observable<string[]>;

  
  ngOnInit(): void {
    }

    onSubmit(signupForm: NgForm): void{
    }
}


