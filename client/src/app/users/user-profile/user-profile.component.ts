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
    this.user = this.fb.group({
      'username': ['vasilik', Validators.compose([Validators.required, Validators.minLength(6)])],
      'email': ['vasile.ion@gmail.com', Validators.compose([Validators.required, Validators.email, Validators.minLength(6)])],
      'workspace': ['LEVI9', Validators.compose([Validators.required, Validators.minLength(4)])]
    })
  }

}
