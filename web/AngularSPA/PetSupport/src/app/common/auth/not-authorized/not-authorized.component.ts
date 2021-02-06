import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-not-authorized',
  templateUrl: './not-authorized.component.html',
  styleUrls: ['./not-authorized.component.css']
})
export class NotAuthorizedComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  public backToMenu(): void {
    this.router.navigateByUrl('');
  }

}
