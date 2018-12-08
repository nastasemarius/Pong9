import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './components/navbar/navbar.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormvalidatorDirective } from './directives/formvalidator.directive';
import {
  MatCardModule,
  MatIconModule,
  MatToolbarModule,
  MatButtonModule,
  MatFormFieldModule,
  MatInputModule,
  MatTabsModule,
  // MatTabLabel,
  // MatTabBody
} from '@angular/material';
import { FormsModule } from '@angular/forms';
import { AuthenticationService } from './services/authentication.service';
import { RouterModule } from '@angular/router';
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
    RouterModule
  ],
  providers: [
    AuthenticationService
  ]
})
export class CoreModule { }
