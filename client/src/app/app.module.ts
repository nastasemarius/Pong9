import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersModule } from './users/users.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CoreModule } from './core/core.module';
import { MatCardModule } from '@angular/material';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    CoreModule,
    BrowserModule,
    BrowserAnimationsModule,  
    AppRoutingModule,
    UsersModule,
    MatCardModule
  ],
  exports: [MatCardModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
