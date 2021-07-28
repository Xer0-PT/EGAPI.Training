import { AuthService } from '@abp/ng.core';
import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { OAuthService } from 'angular-oauth2-oidc';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {
  isModalOpen = false;
  form: FormGroup;

  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  constructor(
    private oAuthService: OAuthService,
    private authService: AuthService,
    private fb: FormBuilder
    ) {}

  openModal(){
    this.buildForm();
    this.isModalOpen = true;
  }

  buildForm() {
    this.form = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required],
    });
  }

  login() {
    if (this.form.invalid){ return; }

    const request = this.authService.navigateToLogin(this.form.value);

    // request.subscribe(() => {
    //   this.isModalOpen = false;
    //   this.form.reset();
    // });
  }
}
