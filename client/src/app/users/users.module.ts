import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { CoreModule } from '../core/core.module';
@NgModule({
  declarations: [UserProfileComponent],
  imports: [
    CommonModule,
    CoreModule
  ]
})
export class UsersModule { }
