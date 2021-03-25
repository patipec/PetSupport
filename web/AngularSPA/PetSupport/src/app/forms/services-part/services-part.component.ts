import {Component, Input, OnInit} from '@angular/core';
import {FormGroup} from '@angular/forms';
import { Services } from '../../common/models/services';


@Component({
  selector: 'app-services-part',
  templateUrl: './services-part.component.html',
  styleUrls: ['./services-part.component.css']
})
export class ServicesPartComponent implements OnInit {
  @Input() services: FormGroup;
  constructor() { }
  enumServices = Services;
  ngOnInit(): void {
  }
  // serviceNameConverter(serviceName: string): number{
  //   //   Boarding = 0,
  //   //   HouseSitting = 1,
  //   //   DogWalking = 2,
  //   //   DropInVisit = 3,
  //   //   DoggyDayCare = 4
  //   // return Services[serviceName];
  // }
  onServiceClick(serviceValue: number): void {
    this.services.get('service').setValue(serviceValue);
  }
}
