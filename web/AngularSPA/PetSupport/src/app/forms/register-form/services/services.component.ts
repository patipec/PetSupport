import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormGroup, NgForm} from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {

  public services: FormGroup;

  constructor(private fb: FormBuilder,
              private http: HttpClient) {
  }
  ngOnInit(): void {
    this.services = this.fb.group({
      service: 'boarding',
      extraServices: this.fb.group( {
        dog: false,
        cat: false,
        other: false
      })
      });
    }
    onExtraServiceClick(service: string): void{
      const extra = this.services.get(`extraServices.${service}`);
      extra.setValue(!extra.value);
      console.log(extra.value);
    }

  onSubmit(): void {

  }
}


