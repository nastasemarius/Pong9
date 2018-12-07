import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { MatCardModule } from '@angular/material';
import { CoreModule } from '../core/core.module';
import { ReactiveFormsModule } from '@angular/forms';
@NgModule({
  declarations: [UserProfileComponent],
  imports: [

    CoreModule,
    CommonModule,
    MatCardModule,
    ReactiveFormsModule
  ]
})
export class UsersModule { }
