import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './component/user/user.component';

import { SignInComponent } from './component/sign-in/sign-in.component';
import { SignUpComponent } from './component/sign-up/sign-up.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EnterComponent } from './component/enter/enter.component';
import { HomeComponent } from './component/home/home.component';
import { NavComponent } from './component/nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,

    SignInComponent,
     SignUpComponent,
     EnterComponent,
     HomeComponent,
     NavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
