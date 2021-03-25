import {Component, Input, OnInit, Output} from '@angular/core';
import { Options, LabelType } from '@angular-slider/ngx-slider';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.scss']
})
export class RangeSliderComponent implements OnInit{
  @Output()
  getInfo = new EventEmitter<any>();
  @Input()
  floor = 0;
  @Input()
  ceil = 1000;
  @Input()
  minValue = 100;
  @Input()
  maxValue = 900;
  @Input()
  currSign = '$';
  @Input()
  step = 0.25;

  options: Options;
  ngOnInit(): void {
    this.options = {
      floor: this.floor,
      ceil: this.ceil,
      step: this.step,
      translate: (value: number, label: LabelType): string => {
        switch (label) {
          case LabelType.Low:
            return `${(this.currSign)}` + value;
          case LabelType.High:
            return `${(this.currSign)}` + value;
          default:
            return '';
        }
      }
    };
  }


}
