import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
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
  constructor(private route: ActivatedRoute, private petsittersService: PetsittersService) {
  }

  ngOnInit(): void {
    this.petsitterId = this.route.snapshot.paramMap.get('id') as string;
    this.petsittersService.getPetsitter(+this.petsitterId).subscribe( data => this.petsitter = data);
  }

}
