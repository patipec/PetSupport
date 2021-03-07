import { HttpClient } from '@angular/common/http';
import {Component, OnInit, Output, EventEmitter} from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { RegistrationService } from '../../registration.service';
import {IBasicInfo} from '../../../../common/models/IRegistration-data';

@Component({
  selector: 'app-bi-form',
  templateUrl: './bi-form.component.html',
  styleUrls: ['./bi-form.component.scss']
})
export class BiFormComponent implements OnInit {
  @Output()
  onFormChanged = new EventEmitter<IBasicInfo>();

  @Output()
  formValid = new EventEmitter<boolean>();

  hide = true;
  submitted = false;
  signupForm = this.fb.group({
    name: ['', [Validators.required, Validators.maxLength(15), Validators.minLength(3), this.nameCheck]],
    surname: ['', [Validators.required, Validators.maxLength(25), Validators.minLength(2), this.surnameCheck]],
    email: ['', [Validators.required, Validators.email, this.emailCheck]],
    phone: ['', [Validators.required, Validators.maxLength(9), this.phoneCheck]],
    password: ['', [Validators.required, Validators.minLength(5), this.passwordCheck]],
    confirmPassword: ['', [Validators.required, Validators.minLength(5), this.passwordCheck]]
  });

  constructor(private http: HttpClient,
              private registrationService: RegistrationService,
              private fb: FormBuilder) {
  this.signupForm.get('password').valueChanges.subscribe(x => this.signupForm.get('confirmPassword').updateValueAndValidity());

}


  ngOnInit(): void {
    this.signupForm.valueChanges.subscribe(value => {
      this.onFormChanged.emit(value);
    });
    this.signupForm.statusChanges.subscribe(status => this.formValid.emit(status === 'VALID'));
  }

  nameCheck(control): any{
    if (control.value != null) {
      const regex = new RegExp('[a-z A-Z]');
      if (regex.test(control.value) !== true){
        return {
          nameValidity: true
        };
      }
    }
  }

  surnameCheck(control): any{
    if (control.value != null) {
      const regex = new RegExp('[a-z A-Z]');
      if (regex.test(control.value) !== true){
        return {
          surnameValidity: true
        };
      }
    }
  }

  emailCheck(control): any{
    if (control.value != null) {
      const regex = new RegExp('[A-Za-z0-9._%-]+@[A-Za-z0-9._%-]+\\.[a-z]{2,3}');
      if (regex.test(control.value) !== true){
        return {
          emailValidity: true
        };
      }
    }
  }

  phoneCheck(control): any{
    if (control.value != null) {
      const regex = new RegExp('[0-9]{9}');
      if (regex.test(control.value) !== true){
        return {
          phoneValidity: true
        };
      }
    }
  }

  passwordCheck(control): any{
    if (control.value != null){
      const conPass = control.value;
      const pass = control.root.get('password');
      if (pass){
        const password = pass.value;
        if (conPass !== '' && password !== ''){
          if (conPass !== password){
            return{
              passwordValidity: true
            };
          }
          else{
            return null;
          }
        }
      }
    }
  }
}
