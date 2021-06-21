import {Component, Input} from '@angular/core';
import {Petsitter} from '../../../common/models/old-models/petsitter';



@Component({
  selector: 'app-petsitters-list',
  templateUrl: './petsitters-list.component.html',
  styleUrls: ['./petsitters-list.component.scss']
})
export class PetsittersListComponent {
  @Input()
  public petsitterList: Petsitter[];
}
