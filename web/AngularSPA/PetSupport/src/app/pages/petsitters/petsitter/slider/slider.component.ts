import { Component, OnInit } from '@angular/core';
import { Gallery, GalleryItem, ImageItem, ThumbnailsPosition, ImageSize } from 'ng-gallery';
import { Lightbox } from 'ng-gallery/lightbox';
@Component({
  selector: 'app-slider2',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent implements OnInit {
  // galleryOptions: NgxGalleryOptions[];
  // galleryImages: NgxGalleryImage[];
  // constructor() { }
  //
  // ngOnInit(): void {
  //
  //   this.galleryOptions = [
  //     {
  //       width: '600px',
  //       height: '400px',
  //       thumbnailsColumns: 4,
  //       imageAnimation: NgxGalleryAnimation.Slide
  //     },
  //     // max-width 800
  //     {
  //       breakpoint: 800,
  //       width: '100%',
  //       height: '600px',
  //       imagePercent: 80,
  //       thumbnailsPercent: 20,
  //       thumbnailsMargin: 20,
  //       thumbnailMargin: 20
  //     },
  //     // max-width 400
  //     {
  //       breakpoint: 400,
  //       preview: false
  //     }
  //   ];
  //   this.galleryImages = [
  //     {
  //       small: './../assets/PetsitterDetail/ExamplePetsitter/1.jpg',
  //       medium: './../assets/PetsitterDetail/ExamplePetsitter/1.jpg',
  //       big: './../assets/PetsitterDetail/ExamplePetsitter/1.jpg'
  //     },
  //     {
  //       small: './../assets/PetsitterDetail/ExamplePetsitter/2.jpg',
  //       medium: './../assets/PetsitterDetail/ExamplePetsitter/2.jpg',
  //       big: './../assets/PetsitterDetail/ExamplePetsitter/2.jpg'
  //     },
  //     {
  //       small: './../assets/PetsitterDetail/ExamplePetsitter/3.jpg',
  //       medium: './../assets/PetsitterDetail/ExamplePetsitter/3.jpg',
  //       big: './../assets/PetsitterDetail/ExamplePetsitter/3.jpg'
  //     },
  //     {
  //       small: './../assets/PetsitterDetail/ExamplePetsitter/4.jpg',
  //       medium: './../assets/PetsitterDetail/ExamplePetsitter/4.jpg',
  //       big: './../assets/PetsitterDetail/ExamplePetsitter/4.jpg'
  //     },
  //     {
  //       small: './../assets/PetsitterDetail/ExamplePetsitter/5.jpg',
  //       medium: './../assets/PetsitterDetail/ExamplePetsitter/5.jpg',
  //       big: './../assets/PetsitterDetail/ExamplePetsitter/5.jpg'
  //     }
  //   ];
  // }
  items: GalleryItem[];

  imageData = [
    {
      srcUrl: './../assets/PetsitterDetail/ExamplePetsitter/1.jpg',
      previewUrl: './../assets/PetsitterDetail/ExamplePetsitter/1.jpg'
    },
    {
      srcUrl: './../assets/PetsitterDetail/ExamplePetsitter/2.jpg',
      previewUrl: './../assets/PetsitterDetail/ExamplePetsitter/2.jpg'
    },
    {
      srcUrl: './../assets/PetsitterDetail/ExamplePetsitter/3.jpg',
      previewUrl: './../assets/PetsitterDetail/ExamplePetsitter/3.jpg'
    },
    {
      srcUrl: './../assets/PetsitterDetail/ExamplePetsitter/4.jpg',
      previewUrl: './../assets/PetsitterDetail/ExamplePetsitter/4.jpg'
    },
    {
      srcUrl: './../assets/PetsitterDetail/ExamplePetsitter/5.jpg',
      previewUrl: './../assets/PetsitterDetail/ExamplePetsitter/5.jpg'
    }
  ];

  constructor(public gallery: Gallery, public lightbox: Lightbox) {
  }

  ngOnInit(): void {

    /** Basic Gallery Example */

    // Creat gallery items
    this.items = this.imageData.map(item => new ImageItem({ src: item.srcUrl, thumb: item.previewUrl }));


    /** Lightbox Example */

      // Get a lightbox gallery ref
    const lightboxRef = this.gallery.ref('lightbox');

    // Add custom gallery config to the lightbox (optional)
    lightboxRef.setConfig({
      imageSize: ImageSize.Cover,
      thumbPosition: ThumbnailsPosition.Top
    });

    // Load items into the lightbox gallery ref
    lightboxRef.load(this.items);
  }
}

