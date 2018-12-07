import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegistrationComponent } from './registration/registration.component';
import { LoginComponent } from './login/login.component';
import { CoreModule } from '../core/core.module';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material';

@NgModule({
  declarations: [RegistrationComponent, LoginComponent],
  imports: [
    CommonModule,
    CoreModule,
    FormsModule
  ]
})
export class AuthenticationModule { }
