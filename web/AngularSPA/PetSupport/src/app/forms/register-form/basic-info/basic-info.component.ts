import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';

@Component({
  selector: 'app-basic-info',
  templateUrl: './basic-info.component.html',
  styleUrls: ['./basic-info.component.css']
})
export class BasicInfoComponent {

  hide = true;
  submitted = false;
  signupForm = this.fb.group({
    name: ['Jan', [Validators.required, Validators.maxLength(15), Validators.minLength(3), this.nameCheck]],
    surname: ['Kowalski', [Validators.required, Validators.maxLength(25), Validators.minLength(2), this.surnameCheck]],
    email: ['jkowalski@gmail.com', [Validators.required, Validators.email, this.emailCheck]],
    phone: ['555666777', [Validators.required, Validators.maxLength(9), this.phoneCheck]],
    password: ['qwerty123', [Validators.required, Validators.minLength(5), this.passwordCheck]],
    confirmPassword: ['qwerty123', [Validators.required, Validators.minLength(5), this.passwordCheck]]
  });

  constructor(private http: HttpClient,
              private registrationService: RegistrationService,
              private fb: FormBuilder) {
  this.signupForm.get('password').valueChanges.subscribe(x => this.signupForm.get('confirmPassword').updateValueAndValidity());

}


  nameCheck(control){
    if (control.value != null) {
      let regex = new RegExp('[a-z A-Z]');
      if (regex.test(control.value) !== true){
        return {
          nameValidity: true
        };
      }
    }
  }

  surnameCheck(control){
    if (control.value != null) {
      let regex = new RegExp('[a-z A-Z]');
      if (regex.test(control.value) !== true){
        return {
          surnameValidity: true
        };
      }
    }
  }

  emailCheck(control){
    if (control.value != null) {
      let regex = new RegExp('[A-Za-z0-9._%-]+@[A-Za-z0-9._%-]+\\.[a-z]{2,3}');
      if (regex.test(control.value) !== true){
        return {
          emailValidity: true
        };
      }
    }
  }

  phoneCheck(control){
    if (control.value != null) {
      let regex = new RegExp('[0-9]{9}');
      if (regex.test(control.value) !== true){
        return {
          phoneValidity: true
        };
      }
    }
  }

  passwordCheck(control){
    if (control.value != null){
      let conPass = control.value;
      let pass = control.root.get('password');
      if (pass){
        let password = pass.value;
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

  onSubmit(): void {
    // this.registrationService.setBasicInfo(this.signupForm.value);
    // this.registrationService.saveUser();
    if (this.signupForm.status === 'VALID'){
      this.registrationService.setBasicInfo(this.signupForm.value);
    }
    else {
      this.signupForm.get('name').markAsTouched();
      this.signupForm.get('surname').markAsTouched();
      this.signupForm.get('phone').markAsTouched();
      this.signupForm.get('email').markAsTouched();
      this.signupForm.get('password').markAsTouched();
      this.signupForm.get('confirmPassword').markAsTouched();
    }
  }
}
