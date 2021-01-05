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
        Id: 1,
        Name: 'Jan',
        Surname: 'Kowalski',
        coordinates: {
          lat: 52,
          lon: 21
        },
        ImageId: 'https://cdn.pixabay.com/photo/2015/05/18/23/53/norway-772991_960_720.jpg',
        City: 'Warszawa',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et cursus dui, ac fermentum metus. Aliquam ultrices orci sapien, et mattis risus facilisis at. Duis ut augue mi. Mauris tristique ligula id erat faucibus blandit. Duis sed congue mauris, quis tempor ipsum. Donec nec odio eu ligula blandit posuere id a enim. In faucibus dui aliquam lorem placerat semper.',
        Price: 15,
      },
      {
        Id: 2,
        Name: 'Jacek',
        Surname: 'Sasin',
        coordinates: {
          lat: 52,
          lon: 21.02
        },
        ImageId: 'https://i.iplsc.com/jacek-sasin/000A3HKWCII40PIF-C123-F4.webp',
        City: 'Kraków',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et cursus dui, ac fermentum metus. Aliquam ultrices orci sapien, et mattis risus facilisis at. Duis ut augue mi. Mauris tristique ligula id erat faucibus blandit. Duis sed congue mauris, quis tempor ipsum. Donec nec odio eu ligula blandit posuere id a enim. In faucibus dui aliquam lorem placerat semper.',
        Price: 70000000,
      },
      {
        Id: 3,
        Name: 'Martyna',
        Surname: 'Wojciechowska',
        coordinates: {
          lat: 52,
          lon: 21.04
        },
        City: 'Kraków',
        ImageId: 'https://dziendobry.tvn.pl/media/cache/content_cover/en-01347491-1626-jpg.jpg',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et cursus dui, ac fermentum metus. Aliquam ultrices orci sapien, et mattis risus facilisis at. Duis ut augue mi. Mauris tristique ligula id erat faucibus blandit. Duis sed congue mauris, quis tempor ipsum. Donec nec odio eu ligula blandit posuere id a enim. In faucibus dui aliquam lorem placerat semper.',
        Price: 0,
      },
      {
        Id: 4,
        Name: 'Wojciech',
        Surname: 'Cejrowski',
        coordinates: {
          lat: 52,
          lon: 21.06
        },
        City: 'Arizona',
        ImageId: 'https://mambiznes.pl/wp-content/uploads/2019/08/forum-0428574145.jpg',
        Description: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer et cursus dui, ac fermentum metus. Aliquam ultrices orci sapien, et mattis risus facilisis at. Duis ut augue mi. Mauris tristique ligula id erat faucibus blandit. Duis sed congue mauris, quis tempor ipsum. Donec nec odio eu ligula blandit posuere id a enim. In faucibus dui aliquam lorem placerat semper.',
        Price: 30,
      }];
  }

}
