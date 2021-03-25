import { Component, OnInit } from '@angular/core';
import {RegistrationService} from '../../registration.service';

@Component({
  selector: 'app-end-of-registration',
  templateUrl: './end-of-registration.component.html',
  styleUrls: ['./end-of-registration.component.scss']
})
export class EndOfRegistrationComponent implements OnInit {

  constructor(private registrationService: RegistrationService) { }

  ngOnInit(): void {
    console.log(this.registrationService);
  }

}
