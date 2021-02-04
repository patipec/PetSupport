import {Component} from '@angular/core';
import {FindPetsitterShortForm} from '../../../common/models/forms';


@Component({
  selector: 'app-pettsiters',
  templateUrl: './pettsiters.component.html',
  styleUrls: ['./pettsiters.component.css']
})
export class PettsittersComponent {
  public longForm: FindPetsitterShortForm;

  public updateLongForm(longForm: FindPetsitterShortForm): void {
    this.longForm = longForm;
  }
}
