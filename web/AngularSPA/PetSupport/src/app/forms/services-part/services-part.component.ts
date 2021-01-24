import {Component, Input, OnInit} from '@angular/core';
import {FormGroup} from '@angular/forms';

@Component({
  selector: 'app-services-part',
  templateUrl: './services-part.component.html',
  styleUrls: ['./services-part.component.css']
})
export class ServicesPartComponent implements OnInit {
  @Input() services: FormGroup;
  constructor() { }

  ngOnInit(): void {
  }
  onServiceClick(serviceValue: string): void {
    this.services.get('service').setValue(serviceValue);
  }
}
