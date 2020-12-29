import {Component, OnChanges, OnInit, SimpleChanges} from '@angular/core';
import {FormGroup, FormBuilder, Validators, AbstractControl, ValidatorFn, FormArray, NgForm} from '@angular/forms';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-long-form',
  templateUrl: './long-form.component.html',
  styleUrls: ['./long-form.component.css'],
  providers: [DatePipe]
})
export class LongFormComponent implements OnInit {
  longFormSettings: FormGroup;
  currSign: string;
  constructor(private fb: FormBuilder, private datePipe: DatePipe) { }

  ngOnInit(): void {
    this.longFormSettings = this.fb.group({
      dateRange: this.fb.group({
        startDate: this.datePipe.transform(new Date(), 'yyyy-MM-dd'),
        stopDate: this.datePipe.transform(new Date(Date.now() + 1 * 24 * 60 * 60 * 1000), 'yyyy-MM-dd')
      }),
      location: '',
      numberOfPets: 1,
      priceRange: this.fb.group({
        minValue: '20',
        maxValue: '300'
      }),
      rateRange: this.fb.group({
        minRate: '',
        maxRate: ''
      }),
      service: 'boarding',
      petType: 'dog',
      hasPet: true,
    });
  }

  onSubmit(): void{
    console.log('Saved: ' + JSON.stringify(this.longFormSettings.value));
  }

  onSliderPriceChange(event: any): void{
    this.longFormSettings.patchValue({
      priceRange: {
        minValue: event.value,
        maxValue: event.highValue
       }
     });
    }

    onSliderRateChange(event: any): void {
      this.longFormSettings.patchValue({
        rateRange: {
          minRate: event.value,
          maxRate: event.highValue
        }
      });
    }
  setSignForSlider(sign: string): string{
    this.currSign = sign;
    return this.currSign;
  }
}
