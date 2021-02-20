import {Component, OnInit} from '@angular/core';
import {FindPetsitterShortForm} from '../../../common/models/forms';
import {Petsitter} from '../../../common/models/petsitter';
import {Pagination, PetsittersService} from '../petsitters.service';
import {ActivatedRoute, Params, Router} from '@angular/router';


@Component({
  selector: 'app-pettsiters',
  templateUrl: './pettsiters.component.html',
  styleUrls: ['./pettsiters.component.css']
})
export class PettsittersComponent implements OnInit {
  public petsitterList: Petsitter[];
  public petSitterFilterData: FindPetsitterShortForm | null;
  public pagination: Pagination = {
    pageNumber: 1,
    pageSize: 20
  };
  public totalRecords;
  public totalPages;
  public recordsRange = this.pagination.pageSize * this.pagination.pageNumber;
  public formData;

  constructor(private petsitterService: PetsittersService,
              private route: ActivatedRoute,
              private router: Router,
  ) {
    this.petSitterFilterData = this.router.getCurrentNavigation().extras.state as FindPetsitterShortForm;
  }

  public ngOnInit(): void {
    const mockData: FindPetsitterShortForm = {city: 'Warsaw', serviceId: '1'};
    const formData = this.petSitterFilterData ?? mockData;
    this.formData = formData;

    this.petsitterService.getPetsittersPage(formData, this.pagination).subscribe((page) => {
      this.petsitterList = page.data;
      this.totalRecords = page.totalRecords;
      this.totalPages = this.getTotalPage();
      this.setParamsToUrl({...formData, ...this.pagination});
    });
  }


  public updateLongForm(formData: FindPetsitterShortForm, clearPagination = true): void {
    if (clearPagination) {
      this.pagination.pageNumber = 1;
    }
    this.formData = formData;
    this.petsitterService.getPetsittersPage(formData, this.pagination).subscribe(page => {
      this.petsitterList = page.data;
      this.totalRecords = page.totalRecords;
      this.totalPages = this.getTotalPage();
    });
    this.setParamsToUrl({...formData, ...this.pagination});
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

  private getTotalPage(): number {
    const total = Number((this.totalRecords / this.pagination.pageSize).toFixed());
    const rest = Number((this.totalRecords / this.pagination.pageSize)) - total;
    console.log(this.totalRecords, total, rest);
    return rest <= 0 || rest >= 0.5 ? total : total + 1;
  }

  public paginationNext(): void {
    this.pagination.pageNumber++;
    this.updateLongForm(this.formData, false);
  }

  public paginationPrev(): void {
    this.pagination.pageNumber--;
    this.updateLongForm(this.formData, false);
  }
}
