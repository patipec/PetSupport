import {Component, Input, OnInit} from '@angular/core';
import {Petsitter} from '../../../../common/models/petsitter';

@Component({
  selector: 'app-petsitter-can-host',
  templateUrl: './petsitter-can-host.component.html',
  styleUrls: ['./petsitter-can-host.component.css']
})
export class PetsitterCanHostComponent implements OnInit {

  constructor() { }
  @Input() petsitter: Petsitter;
  ngOnInit(): void {}


}
