import {ChangeDetectionStrategy, Component, Input} from '@angular/core';
import {FormGroup} from '@angular/forms';
import {ServiceType} from '../../../models/services';
import {PetsitterServicesService} from '../../../services/petsitter-services.service';


@Component({
  selector: 'app-services-part',
  templateUrl: './services-part.component.html',
  styleUrls: ['./services-part.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ServicesPartComponent {
  @Input()
  servicesForm: FormGroup;
  public services = this.petsitterServicesService.getAsList([ServiceType.Boarding, ServiceType.HouseSitting, ServiceType.DogWalking]);

  constructor(private petsitterServicesService: PetsitterServicesService) {
  }

  public changeChosenService(value: number): void {
    this.servicesForm.get('service').setValue(value);
  }
}
