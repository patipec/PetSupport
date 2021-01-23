import {AfterViewInit, Component, ElementRef, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {PetsittersService} from '../petsitters.service';
import {Petsitter} from '../../../common/models/petsitter';

@Component({
  selector: 'app-petsitter',
  templateUrl: './petsitter.component.html',
  styleUrls: ['./petsitter.component.css']
})
export class PetsitterComponent implements OnInit, AfterViewInit {
  private petsitterId: string;
  public petsitter: Petsitter;
  private blockSlider = false;
  constructor(private route: ActivatedRoute, private petsittersService: PetsittersService) {
  }

  ngOnInit(): void {
    this.petsitterId = this.route.snapshot.paramMap.get('id') as string;
    this.petsittersService.getPetsitter(+this.petsitterId).subscribe( data => this.petsitter = data);
    }
  ngAfterViewInit(): void {
    const arrowPrev = document.getElementsByClassName('carousel-arrow-prev');
    const arrowNext = document.getElementsByClassName('carousel-arrow-next');
    this.onArrowClick(arrowPrev);
    this.onArrowClick(arrowNext);
  }
  onArrowClick(arrow): void{
    arrow[0].addEventListener('click', () => {
      if (this.blockSlider === false){
        this.blockSlider = !this.blockSlider;
        new ElementRef(arrow[1] as any).nativeElement.click();
      } else{
        this.blockSlider = !this.blockSlider;
      }
    });

    arrow[1].addEventListener('click', () => {
      if (this.blockSlider === false){
        this.blockSlider = !this.blockSlider;
        new ElementRef(arrow[0] as any).nativeElement.click();
      }else{
        this.blockSlider = !this.blockSlider;
      }
    });
  }
}
