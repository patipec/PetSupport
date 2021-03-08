import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import {Message, MessageBrief, MessageNew} from '../../../common/models/message';

const MESSAGES_URL = 'http://localhost:5001/api/clients';
const getUrl = (clientId) => `${MESSAGES_URL}/${clientId}/messages`;

@Injectable({
  providedIn: 'root'
})
export class MessagesService {

  constructor(private http: HttpClient) {
  }
  public getMessages(clientId= 1): Observable<MessageBrief[]> {
    return this.http.get<MessageBrief[]>(getUrl(clientId));
  }
  public getMessage(clientId= 1, messageId: 2): Observable<Message> {
    return this.http.get<Message>(`${getUrl(clientId)}/${messageId}`);
  }
  public sendMessage(clientId = 1, message: MessageNew): Observable<MessageBrief> {
    return this.http.post<MessageBrief>(`http://localhost:5001/api/clients/${clientId}/messages`, message);
  }
}
