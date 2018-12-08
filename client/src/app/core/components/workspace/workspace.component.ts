import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material';
import { ConfirmDialogComponent } from '../confirm-dialog/confirm-dialog.component';
import { Router } from '@angular/router';
import { Workspace } from '../../models/workspace';
import { WorkspaceService } from '../../services/workspace.service';
@Component({
  selector: 'app-workspace',
  templateUrl: './workspace.component.html',
  styleUrls: ['./workspace.component.scss']
})
export class WorkspaceComponent implements OnInit {
  public newWorkspace: Workspace = new Workspace();
  public selectedWorkspace: Workspace;
  public workspaces: any[];

  constructor(public dialog: MatDialog, private router: Router,
    private workspaceService: WorkspaceService) {
    this.workspaces = [
      { name: 'LEVI9' },
      { name: 'TELE7ABC' }
    ];
  }

  ngOnInit() {

  }
  submitWorkspace() {
    this.workspaceService.createWorkspace(this.newWorkspace).subscribe(() => {
      this.navigateToDashboard();
    });
  }

  navigateToDashboard() {
    this.router.navigate(['dashboard']);
  }

}
