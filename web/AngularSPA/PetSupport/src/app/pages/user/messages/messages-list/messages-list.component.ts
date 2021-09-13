import {Component, OnInit} from '@angular/core';
import {MessagesService} from '../messages.service';
import {MessageBrief} from '../../../../common/models/old-models/message';
import {switchMap, tap} from 'rxjs/operators';
import {PetsittersService} from '../../../petsitters/petsitters.service';
import {merge} from 'rxjs';
import {Petsitter} from '../../../../common/models/old-models/petsitter';

@Component({
  selector: 'app-messages-list',
  templateUrl: './messages-list.component.html',
  styleUrls: ['./messages-list.component.scss']
})
export class MessagesListComponent implements OnInit {
  public messages: MessageBrief[];
  public petsitterData: { [key: number]: Petsitter } = {};
  public isLoaded: boolean;

  constructor(private  messagesService: MessagesService, private petsitterService: PetsittersService) {
  }

  ngOnInit(): void {
    this.messagesService.getMessages(1)
      .pipe(
        switchMap(messages => {
          this.messages = messages;
          const petsittersDataRequests = this.messages.map(message => this.petsitterService.getPetsitter(message.petsitterId));
          return merge(...petsittersDataRequests);
        }),
        tap(c => console.log(c))
      ).subscribe(c => {
        this.petsitterData[c.id] = c;
        this.isLoaded = this.checkIfLoaded();
    });
  }

  checkIfLoaded(): boolean {
    if (!this.messages) {
      return false;
    }
    return this.messages.every(m => {
      if(!this.petsitterData) {
        return false;
      }
      return this.petsitterData[m.petsitterId];
    });
  }
}
