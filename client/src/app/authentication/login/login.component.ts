import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/core/services/authentication.service';
import { Router } from '@angular/router';
import { Credentials } from 'src/app/core/models/credentials';
import { ErrorStateMatcher } from '@angular/material';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  private loginCredentials: Credentials = new Credentials();
  public isWrongPasword = false;
  public errorMessage: string;
  constructor(private authService: AuthenticationService,
    private router: Router) { }

  ngOnInit() {
  }
  onLogin(): void {
    this.authService.login(this.loginCredentials).subscribe((res) => {
      console.log(res);
      this.router.navigate(['/dashboard']);
    }, (err) => {
      this.errorMessage = err.error.error.message;
      this.isWrongPasword = true;
    });
  }

}
