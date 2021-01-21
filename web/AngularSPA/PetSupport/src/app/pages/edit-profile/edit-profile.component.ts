import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-edit-profile',
  templateUrl: './edit-profile.component.html',
  styleUrls: ['./edit-profile.component.css']
})
export class EditProfileComponent {

  display1 = false;
  display2 = false;
  display3 = false;
  display4 = false;

  onPressBasicInfo() {
    this.display1 = true;
    this.display2 = false;
    this.display3 = false;
    this.display4 = false;

    //To toggle the component
    //this.display = !this.display;
  }

  onPressAddress() {
    this.display2 = true;
    this.display1 = false;
    this.display3 = false;
    this.display4 = false;
  }

  onPressServices() {
    this.display3 = true;
    this.display1 = false;
    this.display2 = false;
    this.display4 = false;
  }

  onPressPersonalInfo() {
    this.display4 = true;
    this.display1 = false;
    this.display3 = false;
    this.display2 = false;
  }
}
