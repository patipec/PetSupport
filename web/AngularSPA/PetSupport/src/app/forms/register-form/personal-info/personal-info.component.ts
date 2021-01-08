import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';

@Component({
  selector: 'app-personal-info',
  templateUrl: './personal-info.component.html',
  styleUrls: ['./personal-info.component.css']
})


export class PersonalInfoComponent implements OnInit {

  signupForm: FormGroup;
    
    ngOnInit() {
      this.signupForm = new FormGroup({
        'userData': new FormGroup({
            'birthday': new FormControl(null, Validators.required),
            'title': new FormControl(null, Validators.required),
            'experience': new FormControl(null, Validators.required),
            'availability': new FormControl(null, Validators.required),
            'environment': new FormControl(null, Validators.required)
        }),
      });
    }

    constructor( private registrationService: RegistrationService ) { }
    
      
    onSubmit(control) {
      console.log(this.signupForm);

      //zapisać dane do registration service z tego formularza, zanim wysle na backend
      this.registrationService.setBirthday(this.signupForm.controls['userData.birthday'].value);
      this.registrationService.setTitle(this.signupForm.controls['userData.title'].value);
      this.registrationService.setExperience(this.signupForm.controls['userData.experience'].value);
      this.registrationService.setAvailability(this.signupForm.controls['userData.availability'].value);
      this.registrationService.setEnvironment(this.signupForm.controls['userData.environment'].value);

      //po zapisaniu do serwisu ostatniego formularza personal info (powyzej)
      //uruchamiamy metode z servisu która wyśle wszystkie dane z serwisu na backend
      //robimy to w tym miejsu, ponieważ to zdarzenie bedzie miało miejsce po naciśnieciu przyciusku NEXT na ostatniej str z formularzem
      //this.registrationService.saveUser(control);
    }


}
