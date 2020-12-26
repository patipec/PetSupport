import { Component, OnInit } from '@angular/core';
import {FormGroup, NgForm} from '@angular/forms';
import { FormBuilder, FormControl} from '@angular/forms';
import { Observable } from 'rxjs';
import {DatePipe} from '@angular/common';
import { DateAdapter } from '@angular/material/core';

@Component({
  selector: 'app-short-form',
  templateUrl: './short-form.component.html',
  styleUrls: ['./short-form.component.css'],
  providers: [DatePipe]
})
export class ShortFormComponent implements OnInit {

  public shortFormSettings: FormGroup;

  constructor(private fb: FormBuilder, private datePipe: DatePipe, private dateAdapter: DateAdapter<Date>) {
    this.dateAdapter.setLocale('en-GB');
  }
  ngOnInit(): void {
    this.shortFormSettings = this.fb.group ({
      service: [''],
      location: [''],
      dateRange: this.fb.group({
        startDate: [this.datePipe.transform(new Date(Date.now() + 1 * 24 * 60 * 60 * 1000), 'dd-MM-yyyy')],
        stopDate: [this.datePipe.transform(new Date(Date.now() + 1 * 24 * 60 * 60 * 1000), 'dd-MM-yyyy')]
      }),
      typePet: [''],
  });
  }

  onServiceClick(serviceValue: string): void{
    this.shortFormSettings.get('service').setValue(serviceValue);
  }

  // setBackgroundColor(): void{
  //   this.btnStyle === 'btn-default' ? this.btnStyle = 'btn-change' : this.btnStyle = 'btn-default';
  // }


  onSubmit(): void{

  }

}
