import {Component, Input, OnInit} from '@angular/core';
import {Petsitter} from '../../../../common/models/old-models/petsitter';

@Component({
  selector: 'app-petsitter-reviews',
  templateUrl: './petsitter-reviews.component.html',
  styleUrls: ['./petsitter-reviews.component.scss']
})
export class PetsitterReviewsComponent implements OnInit {
  @Input() petsitter: Petsitter;
  constructor() { }

  ngOnInit(): void {
  }

}
