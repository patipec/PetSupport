import { Component, OnInit } from '@angular/core';
import {FindPetsitterShortForm} from '../../common/models/forms';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.css']
})
export class MainPageComponent implements OnInit {

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
  }
  public sendForm(formData: FindPetsitterShortForm): void {
    void this.router.navigateByUrl('/petsitters', {state: formData});
  }
}
