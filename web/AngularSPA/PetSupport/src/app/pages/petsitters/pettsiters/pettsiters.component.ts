import {Component, OnInit} from '@angular/core';
import {FindPetsitterShortForm} from '../../../common/models/forms';
import {Petsitter} from '../../../common/models/petsitter';
import {PetsittersService} from '../petsitters.service';
import {ActivatedRoute, Params, Router} from '@angular/router';


@Component({
  selector: 'app-pettsiters',
  templateUrl: './pettsiters.component.html',
  styleUrls: ['./pettsiters.component.css']
})
export class PettsittersComponent implements OnInit{
  public petsitterList: Petsitter[];
  public petSitterFilterData: FindPetsitterShortForm | null;

  constructor(private petsitterService: PetsittersService,
              private route: ActivatedRoute,
              private router: Router,
  ) {
    this.petSitterFilterData = this.router.getCurrentNavigation().extras.state as FindPetsitterShortForm;
  }
  public ngOnInit(): void {
    const mockData: FindPetsitterShortForm = {city: 'Warsaw', serviceId: '1'};
    const formData = this.petSitterFilterData ?? mockData;

    this.petsitterService.getPetsitters(formData).subscribe((data) => {
      this.petsitterList = data;
      this.setParamsToUrl(formData);
    });
  }


  public updateLongForm(formData: FindPetsitterShortForm): void {
      this.petsitterService.getPetsitters(formData).subscribe(data => this.petsitterList = data);
      this.setParamsToUrl(formData);
  }

  public setParamsToUrl(formData): void {
    void this.router.navigate(
      [],
      {
        relativeTo: this.route,
        queryParams: formData as Params,
        queryParamsHandling: 'merge', // remove to replace all query params by provided
      });
  }
}
