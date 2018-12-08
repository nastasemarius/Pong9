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
  MatDialogModule
} from '@angular/material';
import { FormsModule } from '@angular/forms';
import { ConfirmDialogComponent } from './components/confirm-dialog/confirm-dialog.component';
import { AuthenticationService } from './services/authentication.service';
import { RouterModule } from '@angular/router';
@NgModule({
  declarations: [
    NavbarComponent,
    FormvalidatorDirective,
    ConfirmDialogComponent
  ],
  imports: [
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
    MatMenuModule,
    RouterModule,
    MatDialogModule
  ],
  exports: [
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
    MatMenuModule,
    RouterModule,
    ],
  providers: [
    ConfirmDialogComponent,
    AuthenticationService
    MatDialogModule,
  ]
})
export class CoreModule { }
