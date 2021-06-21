import {Component, Input, OnInit} from '@angular/core';
import {Petsitter} from '../../../../common/models/old-models/petsitter';

@Component({
  selector: 'app-petsitter-can-host',
  templateUrl: './petsitter-can-host.component.html',
  styleUrls: ['./petsitter-can-host.component.scss']
})
export class PetsitterCanHostComponent implements OnInit {

  constructor() { }
  @Input() petsitter: Petsitter;
  ngOnInit(): void {}


}
