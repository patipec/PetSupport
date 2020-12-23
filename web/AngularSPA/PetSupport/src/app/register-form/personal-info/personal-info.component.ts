import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';

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
            'availability': new FormControl(null, Validators.required, this.forbiddenZipCode),
            'environment': new FormControl(null, Validators.required)
        }),
      });
    }

    constructor( private http: HttpClient) { }

    onSubmit() {
      console.log(this.signupForm);
    }

    forbiddenZipCode(control: FormControl): Promise<any> | Observable<any> {
      const promise = new Promise<any>((resolve, reject) => {
        setTimeout(() => {
          if (control.value === '12-345') {
            resolve({'ZipCodeIsForbidden': true});
          } else {
            resolve(null);
          }
        }, 2000);
      });
      return promise;
    }

    onCreatePost(postData: {title: string; content: string}) {
      this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json', 
      postData
        ).subscribe(responseData => {
          console.log(responseData);
        });
        this.signupForm.reset();
      }
}
