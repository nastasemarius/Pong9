import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'
import { MatDialog } from '@angular/material';
import { ConfirmDialogComponent } from '../../core/components/confirm-dialog/confirm-dialog.component';
@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.scss']
})
export class UserProfileComponent implements OnInit {

  public user: FormGroup;

  constructor(private fb: FormBuilder, public dialog: MatDialog) {

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

  onLeaveWorkspace() {
    const dialogRef = this.dialog.open(ConfirmDialogComponent);
    dialogRef.componentInstance.action = `leave ${this.user.value.workspace}`;
    dialogRef.afterClosed().subscribe(res => {
      if (res) {
        console.log('Trying to delete');
      } else {
        console.log('Gave up on delete');
      }
    })
  }

}
