import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UsersModule } from './users/users.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CoreModule } from './core/core.module';
import { AuthenticationModule } from './authentication/authentication.module';
import { JwtModule } from '@auth0/angular-jwt';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    JwtModule.forRoot({}),
    CoreModule,
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    UsersModule,
    AuthenticationModule
  ],
  exports: [CoreModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
