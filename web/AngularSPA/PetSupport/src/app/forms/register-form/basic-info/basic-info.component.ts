import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import {HttpClient} from '@angular/common/http';
import { RegistrationService } from '../registration.service';

@Component({
  selector: 'app-basic-info',
  templateUrl: './basic-info.component.html',
  styleUrls: ['./basic-info.component.css']
})
export class BasicInfoComponent implements OnInit {

  hide = true;
  submitted = false;

  constructor( private http: HttpClient, private registrationService: RegistrationService) { }

  ngOnInit(): void {
    this.signupForm = new FormGroup({
      'userData': new FormGroup({
      "name" : new FormControl(null, [Validators.required,Validators.maxLength(15),Validators.minLength(2), this.nameCheck]),
      "surname" : new FormControl(null, [Validators.required,Validators.maxLength(25),Validators.minLength(2), this.surnameCheck]),
      "email" : new FormControl(null, [Validators.required, Validators.email, this.emailCheck]),
      "phone" : new FormControl(null, [Validators.required,Validators.maxLength(9), this.phoneCheck]),
      "password" : new FormControl(null, [Validators.required,Validators.minLength(5), this.passwordCheck]),
      "confirmPassword" : new FormControl(null, [Validators.required,Validators.minLength(5), this.passwordCheck])
        })
      });
      this.signupForm.controls.password.valueChanges.subscribe(
        x => this.signupForm.controls.confirmPassword.updateValueAndValidity()
      )
  }

  signupForm: FormGroup;


  nameCheck(control){
    if(control.value != null) {
      var regex = new RegExp('[a-z A-Z]');
      if(regex.test(control.value) !== true){
        return {
          nameValidity: true
        }
      }
    }
  }

  surnameCheck(control){
    if(control.value != null) {
      var regex = new RegExp('[a-z A-Z]');
      if(regex.test(control.value) !== true){
        return {
          surnameValidity: true
        }
      }
    }
  }

  emailCheck(control){
    if(control.value != null) {
      var regex = new RegExp('[A-Za-z0-9._%-]+@[A-Za-z0-9._%-]+\\.[a-z]{2,3}');
      if(regex.test(control.value) !== true){
        return {
          emailValidity: true
        }
      }
    }
  }

  phoneCheck(control){
    if(control.value != null) {
      var regex = new RegExp('[0-9]{9}');
      if(regex.test(control.value) !== true){
        return {
          phoneValidity: true
        }
      }
    }
  }

  passwordCheck(control){
    if(control.value != null){
      var conPass = control.value;
      var pass = control.root.get('password');
      if(pass){
        var password = pass.value
        if(conPass !== "" && password !== ""){
          if(conPass !== password){
            return{
              passwordValidity: true
            }
          }
          else{
            return null
          }
        }
      }
    }
  }

  onSubmit(control) {
    console.log(this.signupForm);
    if(this.signupForm.status == "VALID"){
      this.registrationService.setStreet(this.signupForm.controls['userData.street'].value);
      this.registrationService.setHouseNr(this.signupForm.controls['userData.housenr'].value);
      this.registrationService.setCity(this.signupForm.controls['userData.city'].value);
      this.registrationService.setZipcode(this.signupForm.controls['userData.zipcode'].value);
      this.registrationService.setCountry(this.signupForm.controls['userData.country'].value);
    }
    else {
      this.signupForm.get('name').markAsTouched();
      this.signupForm.get('surname').markAsTouched();
      this.signupForm.get('phone').markAsTouched();
      this.signupForm.get('email').markAsTouched();
      this.signupForm.get('password').markAsTouched();
      this.signupForm.get('confirmPassword').markAsTouched();
    }
    this.signupForm.reset();
  }

  
//***** HTTP METHODS (POST)****//
  // onCreatePost(postData: {title: string; content: string}) {
  //   this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/posts.json', 
  //   postData
  //     ).subscribe(responseData => {
  //       console.log(responseData);
  //     });
  //     this.signupForm.reset();
  //   }
//***** HTTP METHODS (POST)****//

}
