import {FormControl, FormGroup} from '@angular/forms';

export class LongForm {
  priceRange: number[];
  dateRange: FormGroup;
  startDate: FormControl;
  stopDate: FormControl;
  location: string;
  numberOfPets: number;
  service: string;
  rateRange: number;
  typePet: string;
  hasPate: boolean;
}
