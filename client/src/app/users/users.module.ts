import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { MatCardModule } from '@angular/material';
@NgModule({
  declarations: [UserProfileComponent],
  imports: [
    CommonModule,
    MatCardModule
  ]
})
export class UsersModule { }
