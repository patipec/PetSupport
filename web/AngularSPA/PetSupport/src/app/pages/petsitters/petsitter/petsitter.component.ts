import {Component, OnInit} from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {PetsittersService} from '../petsitters.service';
import {Petsitter} from '../../../common/models/petsitter';

@Component({
  selector: 'app-petsitter',
  templateUrl: './petsitter.component.html',
  styleUrls: ['./petsitter.component.css']
})
export class PetsitterComponent implements OnInit {
  private petsitterId: string;
  public petsitter: Petsitter;
  constructor(private route: ActivatedRoute, private petsittersService: PetsittersService, private router: Router) {
  }

  ngOnInit(): void {
    this.petsitterId = this.route.snapshot.paramMap.get('id') as string;
    this.petsittersService.getPetsitter(+this.petsitterId).subscribe( data => this.petsitter = data);
  }

  public navigateToContactPage(): void {
    void this.router.navigateByUrl('contact-form');
  }
}
