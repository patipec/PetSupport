import {HttpClient} from '@angular/common/http';
import {Component} from '@angular/core';
import {FormBuilder} from '@angular/forms';
import {RegistrationService} from '../../../registration.service';
import {appValidators} from '../../../../../common/validators/validators';

@Component({
  selector: 'app-pi-form',
  templateUrl: './pi-form.component.html',
  styleUrls: ['./pi-form.component.scss']
})
export class PiFormComponent {


  public signupForm = this.fb.group({
    birthday: ['', appValidators.birthday],
    title: ['', appValidators.title],
    experience: ['', appValidators.experience],
    availability: ['', appValidators.availability],
    environment: ['', appValidators.environment],
  });

  constructor(private http: HttpClient,
              private registrationService: RegistrationService,
              private fb: FormBuilder) {
  }

}
