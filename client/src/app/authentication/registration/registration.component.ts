import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/core/models/user';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/core/services/authentication.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.scss']
})
export class RegistrationComponent implements OnInit {
  newUser: User = new User();
  private passwordConfirmationField: string;
  private isPasswordMatch: boolean;
  constructor(private authService: AuthenticationService,
    private router: Router) { }

  ngOnInit() {
  }
  register(): void {
    this.authService.register(this.newUser).subscribe(() => {
      this.router.navigate(['/workspace']);
    });
  }
  checkPasswordsMatch(): boolean {
    if (this.newUser.password === this.passwordConfirmationField) {
      this.isPasswordMatch = true;
    } else {
      this.isPasswordMatch = false;
    }
    return this.isPasswordMatch;
  }

}
