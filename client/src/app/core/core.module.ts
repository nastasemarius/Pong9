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
  MatMenuModule
 // MatTabBody
} from '@angular/material';
import { FormsModule } from '@angular/forms';
import { AuthenticationService } from './services/authentication.service';
import { JwtHelperService } from '@auth0/angular-jwt';
@NgModule({
  declarations: [
    NavbarComponent,
    FormvalidatorDirective
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
    RouterModule
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
    RouterModule
    ],
  providers: [
    AuthenticationService,
    JwtHelperService
  ]
})
export class CoreModule { }
