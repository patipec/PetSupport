import { Component, OnInit } from '@angular/core';
import {FormGroup, FormBuilder, Validators, AbstractControl, ValidatorFn, FormArray, NgForm} from '@angular/forms';

@Component({
  selector: 'app-long-form',
  templateUrl: './long-form.component.html',
  styleUrls: ['./long-form.component.css']
})
export class LongFormComponent implements OnInit {
  longFormSettings: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
    this.longFormSettings = this.fb.group({
      dateRange: this.fb.group({
        startDate: new Date(),
        stopDate: new Date()
      }),
      location: '',
      numberOfPets: 1,
      priceRange: this.fb.group({
        minValue: '',
        maxValue: ''
      }),
      rateRange: this.fb.group({
        minRate: '',
        maxRate: ''
      }),
      service: '',
      petType: '',
      hasPate: false,
    });
  }


  onSubmit(): void{
    console.log('Saved: ' + JSON.stringify(this.longFormSettings.value));
  }
}
