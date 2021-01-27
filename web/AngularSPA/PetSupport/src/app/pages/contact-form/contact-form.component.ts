import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import {ActivatedRoute, Router} from '@angular/router';

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

  constructor(private fb: FormBuilder, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
  }
  public sendForm(): void {
    console.log('xd', this.contactForm.value);
    void this.router.navigate(['success'], {relativeTo: this.route});
  }
}
