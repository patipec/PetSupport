import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  public form: FormGroup;
  public loginInvalid: boolean;
  private formSubmitAttempt: boolean;
  private returnUrl: string;

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
  ) { }

  ngOnInit(): void {
    this.form = this.fb.group({
      username: ['', Validators.email],
      password: ['', Validators.required]
    });
  }

    onSubmit(): void {
      this.loginInvalid = false;
      this.formSubmitAttempt = false;
      if (this.form.valid) {
        try {
          const username = this.form.get('username').value;
          const password = this.form.get('password').value;
        } catch (err) {
          this.loginInvalid = true;
        }
      } else {
        this.formSubmitAttempt = true;
      }
    }
}
