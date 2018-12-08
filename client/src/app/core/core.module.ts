import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormvalidatorDirective } from './directives/formvalidator.directive';
import { RouterModule } from '@angular/router';
import {
  MatCardModule,
  MatIconModule,
  MatToolbarModule,
  MatButtonModule,
  MatFormFieldModule,
  MatInputModule,
  MatTabsModule,
  MatMenuModule,
  MatDialogModule,
  MatRadioModule,
  MatTooltipModule,
  MatListModule,
  MatBadgeModule
} from '@angular/material';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ConfirmDialogComponent } from './components/confirm-dialog/confirm-dialog.component';
import { AuthenticationService } from './services/authentication.service';
import { JwtHelperService } from '@auth0/angular-jwt';
import { WorkspaceComponent } from './components/workspace/workspace.component';
import { TableScheduleComponent } from './components/table-schedule/table-schedule.component';
@NgModule({
  declarations: [
    NavbarComponent,
    FormvalidatorDirective,
    ConfirmDialogComponent,
    WorkspaceComponent,
    TableScheduleComponent
  ],
  imports: [
    MatBadgeModule,
    CommonModule,
    HttpClientModule,
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    FlexLayoutModule,
    MatTabsModule,
    FormsModule,
    ReactiveFormsModule,
    MatMenuModule,
    RouterModule,
    MatDialogModule,
    MatRadioModule,
    MatTooltipModule,
    MatListModule
  ],
  exports: [
    MatBadgeModule,
    MatInputModule,
    MatFormFieldModule,
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    NavbarComponent,
    MatButtonModule,
    FlexLayoutModule,
    MatTabsModule,
    FormsModule,
    ReactiveFormsModule,
    MatMenuModule,
    RouterModule,
    WorkspaceComponent,
    MatRadioModule,
    MatTooltipModule,
    MatListModule,
    TableScheduleComponent
  ],
  providers: [
    ConfirmDialogComponent,
    MatDialogModule,
    AuthenticationService,
    JwtHelperService
  ]
})
export class CoreModule { }
