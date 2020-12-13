import { Component, OnInit } from '@angular/core';
import {NgForm, NgModel} from '@angular/forms';
import { ServiceType } from '../form-data/service-type.service';
import { IShortForm } from '../form-data/IShortForm';
import { Observable } from 'rxjs';
import {FormGroup, FormControl} from '@angular/forms';

@Component({
  selector: 'app-short-form',
  templateUrl: './short-form.component.html',
  styleUrls: ['./short-form.component.css']
})
export class ShortFormComponent implements OnInit {

    shortFormSettings: IShortForm = {
    service: '',
    city: '',
    range: new FormGroup({
      start: new FormControl(),
      end: new FormControl()
    }),
    startDate: new FormControl(),
    stopDate: new FormControl(),
    typePet: '',
  };
  servicesTypes$: Observable<string[]>;

  btnCheck: boolean;
  btnStyle = 'form-check-label';

  // onServiceClick(): void{
  //   this.
  //   this.btnCheck === true ? 'btn-default' : 'btn-change';
  // }

  // setBackgroundColor(): void{
  //   this.btnStyle === 'btn-default' ? this.btnStyle = 'btn-change' : this.btnStyle = 'btn-default';
  // }
  ngOnInit(): void {
  }
  //
  // checkTest = function(boolChecked){
  //   console.log(boolChecked);
  // }
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
