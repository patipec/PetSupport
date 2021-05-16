import { Component, OnInit } from '@angular/core';
import { RegistrationService } from '../../registration.service';
import { IPetsitterServices } from '../../../../common/models/IRegistration-data';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.scss']
})
export class ServicesComponent {
  petsitterServices: IPetsitterServices;
  isFormValid: boolean;
  constructor(private registrationService: RegistrationService) {}

  onFormChange(personalServiceInfo: IPetsitterServices): void {
    this.petsitterServices = personalServiceInfo;
  }

  onStatusChange(status: boolean): void {
    this.isFormValid = status;
  }

  onSubmit(): void {
    console.log(this.petsitterServices);
    console.log(this.isFormValid);
    if (this.isFormValid) {
      this.registrationService.setServices(this.petsitterServices);
    }
  }
}


