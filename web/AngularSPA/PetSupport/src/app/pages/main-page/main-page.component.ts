import {Component, OnInit} from '@angular/core';
import {FindPetsitterShortForm} from '../../common/models/forms';
import {ActivatedRoute, Router} from '@angular/router';
import {FormBuilder} from '@angular/forms';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent {
  public testGroup = this.fb.group({
    test: [''],
  });
  public value = '4';

  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder) {
  }

  public sendForm(formData: FindPetsitterShortForm): void {
    void this.router.navigateByUrl('/petsitters', {state: formData});
  }
}
