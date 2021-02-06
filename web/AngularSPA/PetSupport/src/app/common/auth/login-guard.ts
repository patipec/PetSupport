import {CanActivate, Router} from '@angular/router';
import {AuthService} from './auth.service';
import {Injectable} from '@angular/core';

@Injectable({providedIn: 'root'})
export class LoginAuthGuard implements CanActivate {
  constructor(private authService: AuthService, private router: Router) {
  }

  public canActivate(): boolean {
    if (this.authService.isLogged()) {
      return true;
    }
    void this.router.navigateByUrl('/not-authorized');
    return false;
  }
}
