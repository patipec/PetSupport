import {Component, OnInit} from '@angular/core';
import {BreakpointObserver} from '@angular/cdk/layout';
import {combineLatest, Observable} from 'rxjs';
import {ActivatedRoute, NavigationEnd, Router} from '@angular/router';
import {filter, map, startWith, tap} from 'rxjs/operators';


@Component({
  selector: 'app-user-wrapper',
  templateUrl: './user-wrapper.component.html',
  styleUrls: ['./user-wrapper.component.scss']
})
export class UserWrapperComponent implements OnInit {

  public userRoutes = [
    {name: 'Basic Info', path: 'basic-info'},
    {name: 'Address', path: 'address'},
    {name: 'Services', path: 'services'},
    {name: 'Personal Info', path: 'personal-info'},
    {name: 'Gallery', path: 'gallery'},
    {name: 'Password', path: 'password'},
  ];
  public title: string;
  public isDesktop$: Observable<boolean>;
  public isMenuVisible$: Observable<boolean>;
  public navEnd$: Observable<string>;

  constructor(
    private bo: BreakpointObserver,
    private route: ActivatedRoute,
    private router: Router
  ) {
  }

  public ngOnInit(): void {
    this.isDesktop$ = this.bo.observe('(min-width:1280px').pipe(map((v) => v.matches));
    this.navEnd$ = this.router.events.pipe(
      filter((event) => event instanceof NavigationEnd),
      map((event) => (event as NavigationEnd).url),
      startWith(this.router.routerState.snapshot.url),
      tap(url => this.title = this.userRoutes.find(route => url.endsWith(route.path))?.name)
    );
    this.isMenuVisible$ = combineLatest([this.isDesktop$, this.navEnd$]).pipe(
      tap(([isDesktop, url]) => console.log(isDesktop, url)),
      tap(([isDesktop, url]) => this.handleNavigation(isDesktop, url)),
      map(([isDesktop, url]) => isDesktop || this.isUserRootPath(url))
    );
  }

  private handleNavigation(isDesktop: boolean, url: string): void {
    if (isDesktop && this.isUserRootPath(url)) {
      void this.router.navigate(['basic-info'], {relativeTo: this.route});
    }
  }

  private isUserRootPath(url: string): boolean {
    return '/user' === url;
  }

}
