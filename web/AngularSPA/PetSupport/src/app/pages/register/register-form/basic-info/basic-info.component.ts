import { Component } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../../registration.service';
import {IBasicInfo} from '../../../../common/models/IRegistration-data';

@Component({
  selector: 'app-basic-info',
  templateUrl: './basic-info.component.html',
  styleUrls: ['./basic-info.component.scss']
})
export class BasicInfoComponent {
  hide = true;
  basicInfo: IBasicInfo;
  isFormValid: boolean;
  constructor(private http: HttpClient,
              private registrationService: RegistrationService) {}

  onFormChange(basicInfo: IBasicInfo): void {
    this.basicInfo = basicInfo;
  }
  onStatusChange(status: boolean): void {
    this.isFormValid = status;
  }
  onSubmit(): void {
    console.log(this.basicInfo);
    console.log(this.isFormValid);
    if (this.isFormValid) {
      this.registrationService.setBasicInfo(this.basicInfo);
    }
  }


}
