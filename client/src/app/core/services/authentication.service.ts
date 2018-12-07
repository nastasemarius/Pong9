import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Router } from '@angular/router';
import { Credentials } from '../models/credentials';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private baseUrl: any = `${environment.restApiUrl}/Token`;
  private tokenKey = 'pong9-token';
  private credentialsSubject: BehaviorSubject<any> = new BehaviorSubject({});
  public credentials: any;
  constructor(private httpService: HttpClient,
    private router: Router,
    private jwtHelper: JwtHelperService) { }

  login(credentials: Credentials): Observable<any> {
    return this.httpService.post(this.baseUrl, { userName: credentials.userName, password: credentials.password }).pipe(tap(
      (res) => {
        localStorage.setItem(this.tokenKey, res.value);
        this.credentialsSubject.next(this.getTokenInfo(res.value));
      }
    ));
  }
  getToken(): any {
    return JSON.parse(localStorage.getItem(this.tokenKey));
  }
  private getTokenInfo(token): any {
    return this.jwtHelper.decodeToken(token);
  }
}
