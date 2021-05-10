import {Component} from '@angular/core';
import {FormGroup, Validators} from '@angular/forms';
import {FormBuilder} from '@angular/forms';
import {Router} from '@angular/router';
import {IAngularMyDpOptions} from 'angular-mydatepicker';

@Component({
  selector: ' app-short-form',
  templateUrl: './short-form.component.html',
  styleUrls: ['./short-form.component.scss'],
})
export class ShortFormComponent {
  myOptions: IAngularMyDpOptions = {
    dateRange: false,
    dateFormat: 'dd.mm.yyyy'
    // other options...
  };

  public shortFormSettings: FormGroup = this.fb.group({
    service: [1, Validators.required],
    location: ['Warsaw', Validators.required],
    dateRange: this.fb.group({
      startDate: [{isRange: false, singleDate: {jsDate: new Date()}, dateRange: null}, Validators.required],
      endDate: [{isRange: false, singleDate: {jsDate: new Date()}, dateRange: null}, Validators.required],
    }),
    typePet: ['Dog']
  });

  constructor(private fb: FormBuilder, private router: Router) {
  }

  public onSubmit(): void {
    console.log(this.shortFormSettings.value);
  }

  clearDate(): void {
    // Clear the date using the patchValue function
    this.shortFormSettings.patchValue({myDate: null});
  }

  public sendForm(): void {
    const formData = {
      city: this.shortFormSettings.get('location').value,
      serviceId: '1'
    };
    /*    void this.router.navigateByUrl('/petsitters', {state: formData});*/
  }
}


/*
  compareTwoDates: ValidatorFn = (): { [key: string]: any; } | null => {
    let invalid = false;
    const startFrom = this.shortFormSettings.get('dateRange.startDate').value;
    const endTo = this.shortFormSettings.get('dateRange.stopDate').value;

    if (startFrom && endTo) {
      invalid = new Date(startFrom).valueOf() > new Date(endTo).valueOf();
      console.log(startFrom);
    }
    return invalid ? {invalidRange: true} : null;
  }

*/
