import { Component, OnInit } from '@angular/core';
import {NgForm, NgModel} from '@angular/forms';
import { ServiceType } from '../form-data/service-type.service';
import { IShortForm } from '../form-data/IShortForm';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-short-form',
  templateUrl: './short-form.component.html',
  styleUrls: ['./short-form.component.css']
})
export class ShortFormComponent implements OnInit {
  shortFormSettings: IShortForm = {
    service: '',
    city: '',
    startDate: new Date(),
    stopDate: new Date(),
    typePet: ''
  };
  servicesTypes$: Observable<string[]>;
  constructor(private servicesType: ServiceType) {
    this.servicesTypes$ = this.servicesType.getServicesTypes();
  }

  ngOnInit(): void {
  }

  onSubmit(form: NgForm): void{
    // if (form.valid){
    //   this.servicesTypes.postUserSettingsForm(this.userSettings).subscribe(
    //     result => console.log('success: ', result),
    //     error => this.onHttpError(error)
    //   );
    // }else{
    //   this.postError = true;
    //   this.postErrorMessage = 'Please fix above errors';
    // }
  }
  onBlur(field: NgModel): void{
    console.log('in OnBlur', field.valid);
  }
}
