import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material';
import { ConfirmDialogComponent } from '../confirm-dialog/confirm-dialog.component';
import { Router } from '@angular/router';
@Component({
  selector: 'app-workspace',
  templateUrl: './workspace.component.html',
  styleUrls: ['./workspace.component.scss']
})
export class WorkspaceComponent implements OnInit {

  public workspaces: any[];
  public newWorkspace: FormGroup;

  constructor(public fb: FormBuilder, public dialog: MatDialog, private router: Router) {
    this.workspaces = [
      { name: 'LEVI9' },
      { name: 'TELE7ABC' }
    ]
  }

  ngOnInit() {
    this.initNewWorkspace();
  }

  initNewWorkspace() {
    this.newWorkspace = this.fb.group({
      'name': ['', Validators.compose([Validators.required, Validators.minLength(4)])],
      'playerCapacity': [2, Validators.compose([Validators.min(2), Validators.required])],
      'numberOfTables': [2, Validators.compose([Validators.min(2), Validators.required])]
    });
  }
  skipWorkspaceSelection() {
    const dialogRef = this.dialog.open(ConfirmDialogComponent);
    dialogRef.componentInstance.action = 'proceed with unselected workspace';

    dialogRef.afterClosed().subscribe(res => {
      if (res) {
        this.navigateToDashboard();
      }
    })
  }

  submitWorkspace() {
    this.navigateToDashboard();
  };

  navigateToDashboard() {
    this.router.navigate(['dashboard'])
  }

}
