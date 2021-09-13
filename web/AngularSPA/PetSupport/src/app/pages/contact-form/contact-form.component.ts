import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import {ActivatedRoute, Router} from '@angular/router';
import {MessagesService} from '../user/messages/messages.service';
import {MessageNew} from '../../common/models/old-models/message';
import {UserService} from '../user/user.service';

@Component({
  selector: 'app-contact-form',
  templateUrl: './contact-form.component.html',
  styleUrls: ['./contact-form.component.scss']
})
export class ContactFormComponent implements OnInit {
  public petsitterId: number;
  public contactForm = this.fb.group({
    name: [''],
    surname: [''],
    email: [''],
    phone: [''],
    message: ['']
  });

  constructor(private fb: FormBuilder,
              private router: Router,
              private route: ActivatedRoute,
              private messagesService: MessagesService,
              private userService: UserService) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      this.petsitterId = params.id;
    });
    this.contactForm.patchValue(this.userService.getClient());
  }
  public sendForm(): void {
    const message: MessageNew = {
      clientId: 1,
      message: this.contactForm.controls['message'].value,
      petsitterId: this.petsitterId
    };
    this.messagesService.sendMessage(1, message)
      .subscribe(c => {
        console.log(c);
        void this.router.navigate(['success'], {relativeTo: this.route});
      });
  }
}
