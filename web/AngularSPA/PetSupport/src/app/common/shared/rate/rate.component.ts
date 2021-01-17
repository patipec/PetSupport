import { Component, OnChanges, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-rate',
  templateUrl: './rate.component.html',
  styleUrls: ['./rate.component.css']
})
export class RateComponent implements OnChanges {
  @Input() rating: number;
  starWidth: number;

  ngOnChanges(): void {
    this.starWidth = this.rating * 100 / 5 + (this.rating * 3.5);
  }
}
