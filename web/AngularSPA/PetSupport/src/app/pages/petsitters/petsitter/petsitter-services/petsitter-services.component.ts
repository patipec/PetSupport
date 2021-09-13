import {Component, Input, OnInit} from '@angular/core';
import {Petsitter} from '../../../../common/models/old-models/petsitter';

@Component({
  selector: 'app-petsitter-services',
  templateUrl: './petsitter-services.component.html',
  styleUrls: ['./petsitter-services.component.scss']
})
export class PetsitterServicesComponent implements OnInit {
  @Input() petsitter: Petsitter;
  constructor() { }

  ngOnInit(): void {
  }

}
