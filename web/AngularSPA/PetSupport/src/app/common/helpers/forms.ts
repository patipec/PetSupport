import {AbstractControl} from '@angular/forms';
import {toggleValueFromArray} from './array';

export function toggleArrayValueFromFormControl<T>(formControl: AbstractControl, value: T): void {
  const newValue = toggleValueFromArray<T>(formControl.value, value);
  return formControl.patchValue(newValue);
}
