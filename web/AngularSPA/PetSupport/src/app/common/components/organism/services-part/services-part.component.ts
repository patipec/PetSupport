import {Component, Input} from '@angular/core';
import {FormGroup} from '@angular/forms';


@Component({
  selector: 'app-services-part',
  templateUrl: './services-part.component.html',
  styleUrls: ['./services-part.component.scss']
})
export class ServicesPartComponent {
  @Input() servicesForm: FormGroup;
  public services = [
    {name: 'Boarding', value: 0, src: '/assets/shortFormImages/cocker-spaniel.png'},
    {name: 'House Sitting', value: 1, src: '/assets/shortFormImages/dog-heart.png'},
    {name: 'Boarding', value: 2, src: '/assets/shortFormImages/dog-smiley.png'}
  ];

  public changeChosenService(value: number): void {
    this.servicesForm.get('service').setValue(value);
  }
}
