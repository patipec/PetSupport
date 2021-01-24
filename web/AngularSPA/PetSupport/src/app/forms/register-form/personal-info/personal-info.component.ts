import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';

@Component({
  selector: 'app-personal-info',
  templateUrl: './personal-info.component.html',
  styleUrls: ['./personal-info.component.css']
})


export class PersonalInfoComponent {

  signupForm = this.fb.group({
      'birthday': ['', [Validators.required, Validators.maxLength(10), Validators.minLength(10)]],
      'title': ['',[Validators.required, Validators.maxLength(90), Validators.minLength(5)]],
      'experience': ['', [Validators.required, Validators.maxLength(300), Validators.minLength(4)]],
      'availability': ['', [Validators.required, Validators.maxLength(180), Validators.minLength(8)]],
      'environment': ['', [Validators.required, Validators.maxLength(180), Validators.minLength(8)]],
      'image': [null, [Validators.required, //requiredFileType('png')
    ]]
  });

    constructor( private http: HttpClient,
                private registrationService: RegistrationService,
                private fb: FormBuilder ) { }
    
      
    onSubmit(): void {
      //this.registrationService.setPersonalInfo(this.signupForm.value);
      //this.registrationService.saveUser();
      if (this.signupForm.status === 'VALID'){
        this.registrationService.setPersonalInfo(this.signupForm.value);
      }
      else {
        this.signupForm.get('birthday').markAsTouched();
        this.signupForm.get('title').markAsTouched();
        this.signupForm.get('experience').markAsTouched();
        this.signupForm.get('availability').markAsTouched();
        this.signupForm.get('environment').markAsTouched();
      }
      this.registrationService.saveUser();
      //po zapisaniu do serwisu ostatniego formularza personal info (powyzej)
      //uruchamiamy metode z servisu która wyśle wszystkie dane z serwisu na backend
      //robimy to w tym miejsu, ponieważ to zdarzenie bedzie miało miejsce po naciśnieciu przyciusku NEXT na ostatniej str z formularzem
      //this.registrationService.saveUser(control);
    }


}
