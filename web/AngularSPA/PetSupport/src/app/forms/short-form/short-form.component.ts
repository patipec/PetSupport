import { Component, OnInit } from '@angular/core';
import {FormGroup, NgForm} from '@angular/forms';
import { FormBuilder, FormControl} from '@angular/forms';
import { Observable } from 'rxjs';
import {DatePipe} from '@angular/common';

@Component({
  selector: 'app-short-form',
  templateUrl: './short-form.component.html',
  styleUrls: ['./short-form.component.css'],
  providers: [DatePipe]
})
export class ShortFormComponent implements OnInit {

  private shortFormSettings: FormGroup;

  constructor(private fb: FormBuilder, private datePipe: DatePipe) {}
  ngOnInit(): void {
    this.shortFormSettings = this.fb.group ({
      service: [''],
      city: [''],
      dateRange: this.fb.group({
        startDate: this.datePipe.transform(new Date(), 'yyyy-MM-dd'),
        stopDate: this.datePipe.transform(new Date(Date.now() + 1 * 24 * 60 * 60 * 1000), 'yyyy-MM-dd')
      }),
      typePet: '',
  });
  }

  onServiceClick(serviceValue: string): void{

  }

  // setBackgroundColor(): void{
  //   this.btnStyle === 'btn-default' ? this.btnStyle = 'btn-change' : this.btnStyle = 'btn-default';
  // }


  onSubmit(form: NgForm): void{

  }

}
