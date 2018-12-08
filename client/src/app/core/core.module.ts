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
import { RouterModule } from '@angular/router';
import { WorkspaceComponent } from './components/workspace/workspace.component';
@NgModule({
  declarations: [
    NavbarComponent,
    FormvalidatorDirective,
    ConfirmDialogComponent,
    WorkspaceComponent
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
    MatListModule
  ],
  providers: [
    ConfirmDialogComponent,
    AuthenticationService,
    MatDialogModule,
  ]
})
export class CoreModule { }
