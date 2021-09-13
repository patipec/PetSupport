import {ChangeDetectionStrategy, Component, EventEmitter, Input, Output, Renderer2} from '@angular/core';
import {PetInformation, PetPreferenceInformation} from '../../../models/pet-preferences';
import {ServiceTypeDetails} from '../../../models/services';

interface SingleServiceInputData {
  type: 'singleServiceInputData';
  name: string;
  value: number;
  subtitle?: string;
  icon?: string;
}

type Data = SingleServiceInputData | PetInformation | ServiceTypeDetails | PetPreferenceInformation;

@Component({
  selector: 'app-single-service-input',
  templateUrl: './single-service-input.component.html',
  styleUrls: ['./single-service-input.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class SingleServiceInputComponent {
  public mappedData: SingleServiceInputData;
  @Output()
  public inputChanged = new EventEmitter<number>();

  @Input()
  public set data(value: Data) {
    let output = {} as SingleServiceInputData;

    switch (value.type) {
      case 'petInformation': {
        output.name = value.sizeName;
        output.value = value.petWeight;
        output.subtitle = value.sizeDescription;
        break;
      }
      case 'serviceTypeDetails': {
        output.name = value.name;
        output.value = value.value;
        output.icon = value.icon;
        break;
      }
      case 'petPreferenceInformation': {
        output.name = value.petTypeName;
        output.value = value.petType;
        output.icon = value.icon;
        break;
      }
      default: {
        output = value;
        break;
      }
    }
    this.mappedData = output;
  }
  @Input()
  public formValue: (number | number[]);

  public isActive(): boolean {
    if (this.formValue === undefined || this.mappedData?.value === undefined) {
      return false;
    }
    if (Array.isArray(this.formValue)) {
      return this.formValue.includes(this.mappedData.value);
    }
    return this.formValue === this.mappedData.value;
  }

}
