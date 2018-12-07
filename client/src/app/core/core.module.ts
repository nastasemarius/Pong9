import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { NavbarComponent } from './components/navbar/navbar.component';
import { MatCardModule, MatIconModule, MatToolbarModule, MatFormFieldModule, MatInputModule } from '@angular/material';
import { FormvalidatorDirective } from './directives/formvalidator.directive';
@NgModule({
  declarations: [
    NavbarComponent,
    FormvalidatorDirective
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    MatFormFieldModule,
    MatInputModule
  ],
  exports: [
    MatCardModule,
    MatIconModule,
    MatToolbarModule,
    NavbarComponent,
    MatFormFieldModule,
    MatInputModule
  ]
})
export class CoreModule { }
