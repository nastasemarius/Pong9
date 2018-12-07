import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from 'src/app/core/services/authentication.service';
import { Router } from '@angular/router';
import { Credentials } from 'src/app/core/models/credentials';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  private loginCredentials: Credentials;
  public isWrongPasword: boolean;
  constructor(private authService: AuthenticationService,
    private router: Router) { }

  ngOnInit() {
  }
  onLogin(): void {
    this.authService.login(this.loginCredentials).subscribe( () => {
      this.router.navigate(['']);
    });
  }

}
