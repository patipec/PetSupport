import { Component } from '@angular/core';
import { Options, LabelType } from '@angular-slider/ngx-slider';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class RangeSlider {
  minValue = 100;
  maxValue = 1000;
  options: Options = {
    floor: 0,
    ceil: 1000,
    translate: (value: number, label: LabelType): string => {
      switch (label) {
        case LabelType.Low:
          return `$` + value;
        case LabelType.High:
          return `$` + value;
        default:
          return `$` + value;
      }
    }
  };
}
