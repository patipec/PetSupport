import { Component, OnInit } from '@angular/core';
import { MatCarousel, MatCarouselComponent } from '@ngmodule/material-carousel';

@Component({
  selector: 'app-card-carusel',
  templateUrl: './card-carusel.component.html',
  styleUrls: ['./card-carusel.component.css']
})
export class CardCaruselComponent implements OnInit {

  slides = [
    {'image': './../assets/MainPage/carusel3.jpg'}, 
    {'image': './../assets/MainPage/carusel1.jpg'},
    {'image': './../assets/MainPage/carusel3.jpg'}, 
    {'image': './../assets/MainPage/carusel1.jpg'},
    {'image': './../assets/MainPage/carusel3.jpg'}
  ];


  constructor() { }

  ngOnInit(): void {
  }

}
