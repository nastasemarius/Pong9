import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserProfileComponent } from './user-profile/user-profile.component';
import { CoreModule } from '../core/core.module';
import { ReactiveFormsModule } from '@angular/forms';
import { ConfirmDialogComponent } from '../core/components/confirm-dialog/confirm-dialog.component';
@NgModule({
  declarations: [UserProfileComponent],
  imports: [
    CoreModule,
    CommonModule,
    ReactiveFormsModule
  ],
  entryComponents: [ConfirmDialogComponent]
})
export class UsersModule { }
