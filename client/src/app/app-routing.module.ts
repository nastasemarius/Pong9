import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserProfileComponent } from './users/user-profile/user-profile.component';
import { LoginComponent } from './authentication/login/login.component';
import { DashboardComponent } from './users/dashboard/dashboard.component';
import { RegistrationComponent } from './authentication/registration/registration.component';
import { AuthGuard } from './core/guards/auth.guard';
import { WorkspaceComponent } from './core/components/workspace/workspace.component';
import { WorkspaceGuard } from './core/guards/workspace.guard';
const routes: Routes = [
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'registration',
    component: RegistrationComponent
  },
  {
    path: 'profile',
    component: UserProfileComponent
  },
  {
    path: 'dashboard',
    component: DashboardComponent,
    canActivate: [AuthGuard]
  },
  {
    path: 'workspace',
    component: WorkspaceComponent,
    canActivate: [WorkspaceGuard]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
