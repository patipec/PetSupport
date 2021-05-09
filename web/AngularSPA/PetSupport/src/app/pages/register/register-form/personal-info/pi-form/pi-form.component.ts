import {Component} from '@angular/core';
import {FormBuilder} from '@angular/forms';
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

  constructor(private fb: FormBuilder) {}
}
