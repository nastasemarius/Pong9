import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserProfileComponent } from './users/user-profile/user-profile.component';
import { LoginComponent } from './authentication/login/login.component';
import { DashboardComponent } from './users/dashboard/dashboard.component';
import { RegistrationComponent } from './authentication/registration/registration.component';
import { WorkspaceComponent } from './core/components/workspace/workspace.component';
const routes: Routes = [
  // {path: '', redirectTo: 'login', pathMatch: 'full'},
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
    component: DashboardComponent
  },
  {
    path: 'workspace',
    component: WorkspaceComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
