import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-basic-info',
  templateUrl: './basic-info.component.html',
  styleUrls: ['./basic-info.component.css']
})
export class BasicInfoComponent implements OnInit {

  hide = true;
  submitted = false;

  @ViewChild('loginForm') loginForm: NgForm;

  user = {
    name: '',
    surname: '',
    email: '',
    phone: '',
    password: ''
  };

  constructor( private http: HttpClient) { }

  ngOnInit(): void {
  }

  suggestUserName() {
    const suggestedName = 'SuperUser';
    this.loginForm.form.patchValue({
      userData: {
        name: suggestedName
      }
    });
  }

  onSubmit() {
    this.submitted = true;
    this.user.name = this.loginForm.value.userData.name;
    this.user.surname = this.loginForm.value.userData.surname;
    this.user.email = this.loginForm.value.userData.email;
    this.user.phone = this.loginForm.value.userData.phone;
    this.user.password = this.loginForm.value.userData.password;

    this.loginForm.reset();
  }

//***** HTTP METHODS (POST)****//
  onCreatePost(postData: {title: string; content: string}) {
    this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json',
    postData
      ).subscribe(responseData => {
        console.log(responseData);
      });
      this.loginForm.reset();
    }

}
