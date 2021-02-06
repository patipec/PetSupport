import {Component, OnInit} from '@angular/core';
import {Router} from '@angular/router';

@Component({
  selector: 'app-contact-form-success',
  templateUrl: './contact-form-success.component.html',
  styleUrls: ['./contact-form-success.component.css']
})
export class ContactFormSuccessComponent implements OnInit {
  name = 'Agata';
  surname = 'Nowak';
  startDate = '28.10.2020';
  endDate = '02.11.2020';
  services = 'Doggy Day Care';

  constructor(private router: Router) {
  }

  ngOnInit(): void {
  }

  backToHome() {
    void this.router.navigateByUrl('/home');
  }
}
