import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { CoreModule } from '../core/core.module';
import { ReactiveFormsModule } from '@angular/forms';
@NgModule({
  declarations: [UserProfileComponent],
  imports: [
    CoreModule,
    CommonModule,
    ReactiveFormsModule
  ]
})
export class UsersModule { }
