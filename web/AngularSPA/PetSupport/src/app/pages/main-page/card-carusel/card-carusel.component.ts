import {Component, Input, OnInit} from '@angular/core';
import { MatCarousel } from '@ngmodule/material-carousel';

@Component({
  selector: 'app-card-carusel',
  templateUrl: './card-carusel.component.html',
  styleUrls: ['./card-carusel.component.css']
})
export class CardCaruselComponent implements OnInit {

  @Input() slides = [];
  constructor() { }

  ngOnInit(): void {
  }

}
