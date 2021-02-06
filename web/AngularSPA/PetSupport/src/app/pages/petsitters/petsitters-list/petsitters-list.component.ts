import {Component, Input} from '@angular/core';
import {Petsitter} from '../../../common/models/petsitter';



@Component({
  selector: 'app-petsitters-list',
  templateUrl: './petsitters-list.component.html',
  styleUrls: ['./petsitters-list.component.css']
})
export class PetsittersListComponent {
  @Input()
  public petsitterList: Petsitter[];
}
