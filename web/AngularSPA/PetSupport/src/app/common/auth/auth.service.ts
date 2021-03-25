import {Injectable} from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  public isLogged(): boolean {
    return !!localStorage.getItem('msal.idtoken');
  }
}


