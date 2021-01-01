import {Component, OnInit} from '@angular/core';
import {Petsitter} from '../../common/models/petsitter';

@Component({
  selector: 'app-petsitters-list',
  templateUrl: './petsitters-list.component.html',
  styleUrls: ['./petsitters-list.component.css']
})
export class PetsittersListComponent implements OnInit {

  public petsitterList: Petsitter[];

  constructor() {
  }

  ngOnInit(): void {
    this.petsitterList = [
      {
        Name: 'Name',
        Surname: 'Surname',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis mi eu diam ullamcorper, eget suscipit leo tristique.',
        Price: 20,
        ImageId: 'ImageId',
        Id: 1,
        City: 'Gdynia'
      },
      {
        Name: 'Name',
        Surname: 'Surname',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis mi eu diam ullamcorper, eget suscipit leo tristique.',
        Price: 20,
        ImageId: 'ImageId',
        Id: 2,
        City: 'Gdynia'
      }, {
        Name: 'Name',
        Surname: 'Surname',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus iaculis mi eu diam ullamcorper, eget suscipit leo tristique.',
        Price: 20,
        ImageId: 'ImageId',
        Id: 3,
        City: 'Gdynia'
      },

    ];
  }

}
