import { Component, EventEmitter, OnInit, Output} from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { RegistrationService } from '../../registration.service';
import { IPetsitterServices } from '../../IRegistration-data';

@Component({
  selector: 'app-s-form',
  templateUrl: './s-form.component.html',
  styleUrls: ['./s-form.component.css']
})
export class SFormComponent implements OnInit {

  @Output()
  onFormChanged = new EventEmitter<IPetsitterServices>();

  @Output()
  formValid = new EventEmitter<boolean>();

  signupForm = this.fb.group({
    service: 'boarding',
    petPreferences: this.fb.group( {
      dog: false,
      cat: false,
      other: false
    })
  });
  constructor(private fb: FormBuilder,
              private http: HttpClient,
              private registrationService: RegistrationService) {
  }

  ngOnInit(): void {
  }
  onExtraServiceClick(service: string): void{
    const extra = this.signupForm.get(`petPreferences.${service}`);
    extra.setValue(!extra.value);
    const elem = document.getElementById(`_${service}`);
    if (extra.value){
      elem.style.backgroundColor = 'rgb(254, 203, 64)';
    }else{
      elem.style.backgroundColor = 'white';
    }
  }
}
