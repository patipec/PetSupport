import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-basic-info',
  templateUrl: './basic-info.component.html',
  styleUrls: ['./basic-info.component.css']
})
export class BasicInfoComponent implements OnInit {

  hide = true;
  
  submitted = false;

  @ViewChild('loginForm') signupForm: NgForm;

  user = {
    name:'',
    surname: '',
    email: '',
    phone: '',
    password: ''
  };

  constructor() { }

  ngOnInit(): void {
  }

  suggestUserName() {
    const suggestedName = 'SuperUser';
    this.signupForm.form.patchValue({
      userData: {
        name: suggestedName
      }
    });
  }

  onSubmit() {
    this.submitted = true;
    this.user.name = this.signupForm.value.userData.name;
    this.user.surname = this.signupForm.value.userData.surname;
    this.user.email = this.signupForm.value.userData.email;
    this.user.phone = this.signupForm.value.userData.phone;
    this.user.password = this.signupForm.value.userData.password;

    this.signupForm.reset();
  }

}
