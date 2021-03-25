import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {Petsitter} from '../../../common/models/petsitter';
import {PetsittersService} from '../../petsitters/petsitters.service';
import {switchMap} from 'rxjs/operators';

@Component({
  selector: 'app-contact-form-success',
  templateUrl: './contact-form-success.component.html',
  styleUrls: ['./contact-form-success.component.scss']
})
export class ContactFormSuccessComponent implements OnInit {
  name = 'Agata';
  surname = 'Nowak';
  startDate = '28.10.2020';
  endDate = '02.11.2020';
  services = 'Doggy Day Care';
  public petsitter: Petsitter;

  constructor(private router: Router,
              private route: ActivatedRoute,
              private petsitterService: PetsittersService) {
  }

  ngOnInit(): void {
    this.route.params
      .pipe(
        switchMap(p =>
          this.petsitterService.getPetsitter(p.id))
      )
      .subscribe(p => this.petsitter = p);

  }

  backToHome() {
    void this.router.navigateByUrl('/home');
  }
}
