import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { BehaviorSubject, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Credentials } from '../models/credentials';
import { tap } from 'rxjs/operators';
import { User } from '../models/user';
import * as jwtDecode from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private loginUrl: any = `${environment.apiUrl}/user/authenticate`;
  private registerUrl: any = `${environment.apiUrl}/user/register`;
  private tokenKey = 'pong9-token';
  private userId = 'pong9-user';
  private credentialsSubject: BehaviorSubject<any> = new BehaviorSubject({});
  public credentials: any;
  constructor(private httpService: HttpClient,
    private router: Router) { }

  login(credentials: Credentials): Observable<any> {
    return this.httpService.post(this.loginUrl, { userName: credentials.userName, password: credentials.password }).pipe(tap(
      (res) => {
        localStorage.setItem(this.tokenKey, res);
        this.credentialsSubject.next(this.getTokenInfo(res));
      }
    ));
  }
  getToken(): any {
    return localStorage.getItem(this.tokenKey);
  }
  register(user: User): Observable<any> {
    return this.httpService.post(this.registerUrl, user).pipe(tap(
      (res) => {
        localStorage.setItem(this.userId, res);
      }
    ));
  }
  isUserAuthenticated(): boolean {
    const token = this.getToken();
    if (token && !this.isTokenExpired()) {
      return true;
    }
    return false;
  }
  isTokenExpired(): boolean {
    const token = this.getToken();
    const current_time = new Date().getTime() / 1000;
    if (token) {
      return current_time > this.getTokenInfo(token).exp;
    }
    return true;
  }
  isUserRegistered(): boolean {
    const userId = this.getUserId();
    if (userId) {
      return true;
    }
    return false;
  }
  getUserId(): any {
    return localStorage.getItem(this.userId);
  }
  logout(): void {
    localStorage.clear();
    this.router.navigate(['/login']);
  }
  private getTokenInfo(token): any {
    return jwtDecode(token);
  }
}
