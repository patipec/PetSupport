import {Component, Input, OnInit} from '@angular/core';
import {Petsitter} from '../../../../common/models/petsitter';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-petsitter-list-tile',
  templateUrl: './petsitter-list-tile.component.html',
  styleUrls: ['./petsitter-list-tile.component.css']
})
export class PetsitterListTileComponent implements OnInit {
  @Input() petsitter: Petsitter;

  constructor(
    private route: ActivatedRoute,
    private router: Router
  ) {
  }

  ngOnInit(): void {
  }

  public navigateToPetsitterDetails(petsitterId) {
    this.router.navigate([petsitterId], {relativeTo: this.route});
  }
}
