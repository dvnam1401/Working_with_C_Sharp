import { AuthService } from './../services/auth.service';
import { Component, OnDestroy } from '@angular/core';
import { LoginRequest } from '../models/login-request.model';
import { CookieService } from 'ngx-cookie-service';
import { Router } from '@angular/router';
import { Subscriber, Subscription } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnDestroy {
  model: LoginRequest;
  private addCookie?: Subscription;
  constructor(private authService: AuthService,
    private cookieService: CookieService,
    private router: Router) {
    this.model = {
      email: '',
      password: ''
    }
  }
  onFormSubmit(): void {
    this.addCookie = this.authService.login(this.model)
      .subscribe({
        next: (response => {
          //set auth cookie
          this.cookieService.set('Authorization', `Bearer ${response.token}`, undefined, '/', undefined, true, 'Strict');
          //set user
          this.authService.setUser({
            email: response.email,
            roles: response.roles
          });
          //redirect back to home
          this.router.navigateByUrl('/');
        })
      })
  }
  ngOnDestroy(): void {
    this.addCookie?.unsubscribe();
  }


}
