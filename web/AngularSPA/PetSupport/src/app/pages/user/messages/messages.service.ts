import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {Message, MessageBrief, MessageNew} from '../../../common/models/old-models/message';
import {HttpService} from '../../../common/services/http.service';

const MESSAGES_URL = 'clients';
const getUrl = (clientId) => `${MESSAGES_URL}/${clientId}/messages`;

@Injectable({
  providedIn: 'root'
})
export class MessagesService {

  constructor(private http: HttpService) {
  }
  public getMessages(clientId= 1): Observable<MessageBrief[]> {
    return this.http.get<MessageBrief[]>(getUrl(clientId));
  }
  public getMessage(clientId= 1, messageId: 2): Observable<Message> {
    return this.http.get<Message>(`${getUrl(clientId)}/${messageId}`);
  }
  public sendMessage(clientId = 1, message: MessageNew): Observable<MessageBrief> {
    return this.http.post<MessageBrief>(`${getUrl(clientId)}`, message);
  }
}
