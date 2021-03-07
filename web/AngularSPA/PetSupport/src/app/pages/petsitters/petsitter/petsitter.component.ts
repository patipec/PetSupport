import {AfterViewInit, Component, ElementRef, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {PetsittersService} from '../petsitters.service';
import {Petsitter} from '../../../common/models/petsitter';

@Component({
  selector: 'app-petsitter',
  templateUrl: './petsitter.component.html',
  styleUrls: ['./petsitter.component.scss']
})
export class PetsitterComponent implements OnInit, AfterViewInit {
  private petsitterId: string;
  public petsitter: Petsitter;
  private blockSlider = false;

  constructor(private route: ActivatedRoute, private petsittersService: PetsittersService, private router: Router) {
  }

  ngOnInit(): void {
    this.petsitterId = this.route.snapshot.paramMap.get('id') as string;

    /*    this.route.params.subscribe(params =>  {
          this.petsitterId = params.id;
        });*/
    this.petsittersService.getPetsitter(+this.petsitterId).subscribe(data => this.petsitter = data);
  }

  ngAfterViewInit(): void {
    const arrowsPrev = document.getElementsByClassName('carousel-arrow-prev');
    const arrowsNext = document.getElementsByClassName('carousel-arrow-next');
    this.onArrowClick(arrowsPrev);
    this.onArrowClick(arrowsNext);
  }

  onArrowClick(arrows): void {
    this.bindSliderArrows(arrows[0], arrows[1]);
    this.bindSliderArrows(arrows[1], arrows[0]);
  }

  public navigateToContactPage(): void {
    void this.router.navigateByUrl(`contact-form/${this.petsitterId}`);
  }
  private bindSliderArrows(trigger, target): void {
    trigger.addEventListener('click', () => {
      if (this.blockSlider === false) {
        this.blockSlider = !this.blockSlider;
        new ElementRef(target as any).nativeElement.click();
      } else {
        this.blockSlider = !this.blockSlider;
      }
    });
  }
}
