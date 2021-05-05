import {Component, OnInit, Output, EventEmitter, Input} from '@angular/core';
import {FormGroup} from '@angular/forms';

@Component({
  selector: 'app-single-service-input',
  templateUrl: './single-service-input.component.html',
  styleUrls: ['./single-service-input.component.scss']
})
export class SingleServiceInputComponent implements OnInit {
  @Input()
  public data: { name: string, src: string, value: number};
  @Input()
  public serviceForm: FormGroup;
  @Output()
  public serviceChoose = new EventEmitter<number>();

  public get chosenService(): number {
    return this.serviceForm.get('service').value;
  }

  constructor() {
  }

  ngOnInit(): void {
  }

}
