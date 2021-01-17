import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.css']
})
export class ContactFormComponent implements OnInit {
  public contactForm = this.fb.group({
    name: [''],
    surname: [''],
    email: [''],
    phone: [''],
    message: ['']
  });

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
  }
  public sendForm(): void {
    console.log('xd', this.contactForm.value);
  }
}
