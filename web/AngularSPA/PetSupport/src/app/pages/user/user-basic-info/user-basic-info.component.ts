import { Component, OnInit } from '@angular/core';
import {FormBuilder} from '@angular/forms';
import {appValidators} from '../../../common/validators/validators';
import {UserQuery} from '../state/user.query';
import {first} from 'rxjs/operators';

@Component({
  selector: 'app-user-basic-info',
  templateUrl: './user-basic-info.component.html',
  styleUrls: ['./user-basic-info.component.scss']
})
export class UserBasicInfoComponent implements OnInit {
  public form = this.fb.group({
    name: ['', appValidators.name],
    surname: ['', appValidators.surname],
    email: ['', appValidators.email],
    phoneNumber: ['', appValidators.phone],
  });
  constructor(private fb: FormBuilder, private userQuery: UserQuery) { }

  public ngOnInit(): void {
    this.userQuery.basicInfo$.pipe(first()).subscribe(userInfo => this.form.patchValue(userInfo));
  }
  public onSubmit(event): void {
    console.log(event);
  }
}
