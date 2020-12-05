import {FormControl, FormGroup} from '@angular/forms';

export interface IShortForm {
  service: string;
  city: string;
  // start: FormControl;
  // end: FormControl;
  // range: FormGroup;
  range: FormGroup;
  startDate: FormControl;
  stopDate: FormControl;
  typePet: string;
}

// range: new FormGroup({
//   start: new FormControl(),
//   end: new FormControl()
// })
