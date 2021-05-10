import {HttpClient} from '@angular/common/http';
import {Component, OnInit, Output, EventEmitter} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {RegistrationService} from '../../../registration.service';
import {appValidators} from '../../../../../common/validators/validators';

@Component({
  selector: 'app-bi-form',
  templateUrl: './bi-form.component.html',
  styleUrls: ['./bi-form.component.scss']
})
export class BiFormComponent {
  @Output()
  public formSubmitted = new EventEmitter<FormGroup>();

  hide = true;
  signupForm = this.fb.group({
    name: ['', appValidators.name],
    surname: ['', appValidators.surname],
    email: ['', appValidators.email],
    phone: ['', appValidators.phone],
/*    password: ['', [Validators.required, Validators.minLength(5), this.passwordCheck]],
    confirmPassword: ['', [Validators.required, Validators.minLength(5), this.passwordCheck]]*/
  });

  constructor(private http: HttpClient,
              private registrationService: RegistrationService,
              private fb: FormBuilder) {
  }


  public onSubmit(): void {
    console.log(this.signupForm);
  }

  passwordCheck(control): any {
    if (control.value != null) {
      const conPass = control.value;
      const pass = control.root.get('password');
      if (pass) {
        const password = pass.value;
        if (conPass !== '' && password !== '') {
          if (conPass !== password) {
            return {
              passwordValidity: true
            };
          } else {
            return null;
          }
        }
      }
    }
  }
}
