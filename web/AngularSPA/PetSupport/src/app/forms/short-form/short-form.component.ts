import {Component, OnInit} from '@angular/core';
import {AbstractControl, FormGroup, NgForm, ValidatorFn, Validators} from '@angular/forms';
import {FormBuilder, FormControl} from '@angular/forms';
import {Observable} from 'rxjs';
import {DatePipe} from '@angular/common';
import {DateAdapter} from '@angular/material/core';

@Component({
  selector: 'app-short-form',
  templateUrl: './short-form.component.html',
  styleUrls: ['./short-form.component.css'],
  providers: [DatePipe]
})
export class ShortFormComponent implements OnInit {

  public shortFormSettings: FormGroup;

  constructor(private fb: FormBuilder, private datePipe: DatePipe, private dateAdapter: DateAdapter<Date>) {
    this.dateAdapter.setLocale('en-GB');
  }

  ngOnInit(): void {
    this.shortFormSettings = this.fb.group({
      service: ['houseSitting', [Validators.required]],
      location: ['Warsaw', [Validators.required, Validators.pattern(/^[a-zA-Z-,]+(\s{0, 1}[a-zA-Z-, ])*$/)]],
      dateRange: this.fb.group({
        startDate: [this.datePipe.transform(new Date(), 'yyyy-MM-dd'), [Validators.required]],
        stopDate: [this.datePipe.transform(new Date(Date.now() + 2 * 24 * 60 * 60 * 1000), 'yyyy-MM-dd'), [Validators.required]]
      }, this.compareTwoDates),
      typePet: ['Dog', Validators.required],
    });
  }

  onServiceClick(serviceValue: string): void {
    this.shortFormSettings.get('service').setValue(serviceValue);
  }

  compareTwoDates: ValidatorFn = (): { [key: string]: any; } | null => {
    let invalid = false;
    const startFrom = this.shortFormSettings.get('dateRange.startDate').value;
    const endTo = this.shortFormSettings.get('dateRange.stopDate').value;

    if (startFrom && endTo) {
      invalid = new Date(startFrom).valueOf() > new Date(endTo).valueOf();
      console.log(startFrom);
    }
    return invalid ? { invalidRange: true} : null;
}

onSubmit(): void {}

}
