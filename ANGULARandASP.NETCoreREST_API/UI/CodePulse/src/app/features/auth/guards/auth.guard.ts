import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { CookieService } from 'ngx-cookie-service';
import { AuthService } from '../services/auth.service';
import { jwtDecode } from 'jwt-decode';

export const authGuard: CanActivateFn = (route, state) => {
  const cookieService = inject(CookieService);
  const authService = inject(AuthService);
  const router = inject(Router);
  const user = authService.getUser();

  //check for the JWT token
  let token = cookieService.get('Authorization');
  if (token && user) {
    token = token.replace('Bearer ', '');
    const decodeToken: any = jwtDecode(token);

    //check if token has expired
    const expirationDate = decodeToken.exp * 1000;
    const currentTime = new Date().getTime();

    if (currentTime > expirationDate) {
      //logout
      authService.logout();
      return router.createUrlTree(['/login'], { queryParams: { returnUrl: state.url } });
    } else {
      //token is valid
      if (user.roles.includes('Writer')) {
        return true;
      }
      else {
        alert('Unauthorized');
        return false;
      }
    }
  } else {
    //logout
    authService.logout();
    return router.createUrlTree(['/login'], { queryParams: { returnUrl: state.url } });
  }
};
