import {Injectable} from '@angular/core';

export interface Client {
  name: string;
  surname: string;
  email: string;
  phone: string;
  clientId: number;
}

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor() {}

  public getClient(): Client {
    return {name: 'Paweł', surname: 'Bednarczyk', email: 'bedpaw97@gmail.com', phone: '666666666', clientId: 1};
  }
}


