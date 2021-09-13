import {Component, OnInit, Output} from '@angular/core';
import {FormGroup, FormBuilder, Validators} from '@angular/forms';
import {DatePipe} from '@angular/common';
import {EventEmitter} from '@angular/core';
import {FindPetsitterShortForm} from '../../../common/models/old-models/forms';
import {fromEnum, Services} from '../../../common/models/old-models/services';

@Component({
  selector: 'app-long-form',
  templateUrl: './long-form.component.html',
  styleUrls: ['./long-form.component.scss'],
  providers: [DatePipe]
})
export class LongFormComponent implements OnInit {
  longFormSettings: FormGroup;
  currSign: string;
  public services = fromEnum(Services);
  @Output()
  public longForm = new EventEmitter<FindPetsitterShortForm>();


  constructor(private fb: FormBuilder, private datePipe: DatePipe) {
  }

  ngOnInit(): void {
    this.longFormSettings = this.fb.group({
      dateRange: this.fb.group({
        startDate: [this.datePipe.transform(new Date(), 'yyyy-MM-dd'),
          [Validators.required]],
        stopDate: [this.datePipe.transform(new Date(Date.now() + 1 * 24 * 60 * 60 * 1000), 'yyyy-MM-dd'),
          [Validators.required]]
      }),
      location: ['Warsaw', Validators.required],
      numberOfPets: [1],
      priceRange: this.fb.group({
        minValue: ['30', [Validators.required]],
        maxValue: ['300', [Validators.required]]
      }),
      rateRange: this.fb.group({
        minRate: ['2', [Validators.required]],
        maxRate: ['4', [Validators.required]]
      }),
      service: [1, [Validators.required]],
      petType: ['dog', [Validators.required]],
      hasPet: [true],
    });
  }

  onSubmit(): void {
    const value = this.longFormSettings.value;

    const filters = {
      city: value.location,
      serviceId: value.service.toString(),
      street: '',
      minPrice: value.priceRange.minValue,
      maxPrice: value.priceRange.maxValue,
    };
    this.longForm.emit(filters);
  }


  onSliderPriceChange(event: any): void {
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

  setSignForSlider(sign: string): string {
    this.currSign = sign;
    return this.currSign;
  }
}
