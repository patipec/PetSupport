import { Component } from '@angular/core';
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
  constructor(private registrationService: RegistrationService) {}

  onSubmit(): void {
    console.log(this.basicInfo);
    console.log(this.isFormValid);
    if (this.isFormValid) {
      this.registrationService.setBasicInfo(this.basicInfo);
    }
  }


}
