import {Component, OnChanges, OnInit, SimpleChanges} from '@angular/core';
import {FormGroup, FormBuilder, Validators, AbstractControl, ValidatorFn, FormArray, NgForm} from '@angular/forms';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-long-form',
  templateUrl: './long-form.component.html',
  styleUrls: ['./long-form.component.css'],
  providers: [DatePipe]
})
export class LongFormComponent implements OnInit, OnChanges {
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
        minValue: '',
        maxValue: ''
      }),
      rateRange: this.fb.group({
        minRate: '',
        maxRate: ''
      }),
      service: 'boarding',
      petType: 'dog',
      hasPet: true,
    });
    // console.log(this.longFormSettings.get('priceRange.minValue'));
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('sth');
  }

  onSubmit(): void{
    console.log('Saved: ' + JSON.stringify(this.longFormSettings.value));
  }

  onSliderChange(event: any): void{
    // console.log(event);
    // this.sliderPriceMin = event.value;
    // console.log(event.value);
    // console.log(event.highValue);


  }
  setSignForSlider(sign: string): string{
    this.currSign = sign;
    return this.currSign;
  }
}
