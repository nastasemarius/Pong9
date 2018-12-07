import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatCardModule, MatIconModule, MatToolbarModule } from '@angular/material';
@NgModule({
  declarations: [
    NavbarComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
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
