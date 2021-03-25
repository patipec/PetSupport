import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-card-carusel',
  templateUrl: './card-carusel.component.html',
  styleUrls: ['./card-carusel.component.scss']
})
export class CardCaruselComponent implements OnInit {

  @Input() slides = [];
  constructor() { }

  ngOnInit(): void {
  }

}
