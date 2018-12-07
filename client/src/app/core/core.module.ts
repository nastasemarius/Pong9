import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatCardModule, MatIconModule, MatToolbarModule } from '@angular/material';
@NgModule({
  declarations: [
    NavbarComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatIconModule,
    MatToolbarModule
  ],
  exports: [
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    NavbarComponent
  ]
})
export class CoreModule { }
