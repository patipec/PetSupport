import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { IPersonalInfo } from '../../../../../common/models/IRegistration-data';
import { RegistrationService } from '../../../registration.service';

@Component({
  selector: 'app-pi-form',
  templateUrl: './pi-form.component.html',
  styleUrls: ['./pi-form.component.scss']
})
export class PiFormComponent implements OnInit {

  @Output()
  onFormChanged = new EventEmitter<IPersonalInfo>();

  @Output()
  formValid = new EventEmitter<boolean>();

  signupForm = this.fb.group({
    birthday: ['', [Validators.required, Validators.maxLength(10), Validators.minLength(10)]],
    title: ['', [Validators.required, Validators.maxLength(90), Validators.minLength(5)]],
    experience: ['', [Validators.required, Validators.maxLength(300), Validators.minLength(4)]],
    availability: ['', [Validators.required, Validators.maxLength(180), Validators.minLength(8)]],
    environment: ['', [Validators.required, Validators.maxLength(180), Validators.minLength(8)]]
});

  constructor( private http: HttpClient,
               private registrationService: RegistrationService,
               private fb: FormBuilder ) { }

  ngOnInit(): void {
    this.signupForm.valueChanges.subscribe(value => {
      this.onFormChanged.emit(value);
    });
    this.signupForm.statusChanges.subscribe(
      status => this.formValid.emit(status === 'VALID'));
  }
}
