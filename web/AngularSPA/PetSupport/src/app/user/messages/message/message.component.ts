import { Component, OnInit } from '@angular/core';
import {MessagesService} from '../messages.service';
import {ActivatedRoute, Router} from '@angular/router';
import {switchMap} from 'rxjs/operators';
import {Observable} from 'rxjs';
import {Message} from '../../../common/models/message';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.scss']
})
export class MessageComponent implements OnInit {
  public message$: Observable<Message>
  constructor(private messageService: MessagesService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.message$ = this.route.params.pipe(switchMap(params =>
      this.messageService.getMessage(1, params.id)
    ));
  }
}
