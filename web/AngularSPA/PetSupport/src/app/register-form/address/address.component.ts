import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Observable } from 'rxjs';
import {HttpClient} from '@angular/common/http';


@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrls: ['./address.component.css']
})
export class AddressComponent {

    signupForm: FormGroup;

    ngOnInit() {
      this.signupForm = new FormGroup({
        'userData': new FormGroup({
            'street': new FormControl(null, [Validators.required]),
            'housenr': new FormControl(null, Validators.required),
            'city': new FormControl(null, Validators.required),
            'zipcode': new FormControl(null, Validators.required, this.forbiddenZipCode),
            'country': new FormControl('Poland')
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
