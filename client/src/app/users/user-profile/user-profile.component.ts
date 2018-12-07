import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators, Form } from '@angular/forms'

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.scss']
})
export class UserProfileComponent implements OnInit {

  public user: FormGroup;

  constructor(private fb: FormBuilder) {

  }

  ngOnInit() {
    const userData = {
      username: 'vasilik',
      email: 'vasilik@gmail.com',
      workspace: 'LEVI9'
    }
    this.initializeUser(userData);
  }

  initializeUser({ username, email, workspace }) {
    this.user = this.fb.group({
      'username': [username, Validators.compose([Validators.required, Validators.minLength(6)])],
      'email': [email, Validators.compose([Validators.required, Validators.email, Validators.minLength(6)])],
      'workspace': [workspace, Validators.compose([Validators.required, Validators.minLength(4)])]
    });
  }

}
