import {FormControl, Validators} from '@angular/forms';
import {Observable} from 'rxjs';

const DISABLE_VALIDATION = false;

interface AppValidators<T> {
  houseNr: T;
  street: T;
  city: T;
  zipCode: T;
  country: T;
  name: T;
  surname;
  email: T;
  phone: T;
  birthday: T;
  title: T;
  experience: T;
  availability: T;
  environment: T;
}

export let appValidators: AppValidators<Validators[]> = {
  houseNr: validatorsFactory(0, 10, [
    /*    Validators.pattern('^[a-zA-Z0-9_.+-]+/[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$')*/
  ]),
  street: validatorsFactory(3, 25),
  city: validatorsFactory(3, 30),
  zipCode: validatorsFactory(3, 6, /*[forbiddenZipCode]*/),
  name: validatorsFactory(2, 15),
  country: validatorsFactory(3, 30),
  surname: validatorsFactory(2, 25),
  email: validatorsFactory(5, 100, /*[Validators.email]*/),
  phone: validatorsFactory(9, 9, /*[Validators.pattern('[0-9]{9}')]*/),
  birthday: validatorsFactory(10, 10),
  title: validatorsFactory(5, 90),
  experience: validatorsFactory(4, 300),
  availability: validatorsFactory(8, 100),
  environment: validatorsFactory(8, 100),
};

function validatorsFactory(
  minLength: number,
  maxLength: number,
  advancedValidators = [] as Validators[]): Validators[] {
  if (DISABLE_VALIDATION) {
    return [];
  }
  return [
    Validators.required,
    Validators.minLength(minLength),
    Validators.maxLength(maxLength),
    ...advancedValidators];
}

function forbiddenZipCode(control: FormControl): Promise<any> | Observable<any> {
  const promise = new Promise<any>((resolve, reject) => {
    setTimeout(() => {
      if (control.value === '00-000') {
        resolve({ZipCodeIsForbidden: true});
      }
      if (control.value === '00000') {
        resolve({ZipCodeIsForbidden: true});
      } else {
        resolve(null);
      }

    }, 1000);
  });
  return promise;
}
