import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './home/nav-menu/nav-menu.component';
import { LoginFormComponent } from './home/login-form/login-form.component';
import { SignupFormComponent } from './home/signup-form/signup-form.component';
import { HomeComponent } from './home/home/home.component';
import { SideNavTogglerComponent } from './authorised/side-nav-toggler/side-nav-toggler.component';
import { SideNavComponent } from './authorised/side-nav/side-nav.component';
import { LayoutComponent } from './authorised/layout/layout.component';
import { TopNavComponent } from './authorised/top-nav/top-nav.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    LoginFormComponent,
    SignupFormComponent,
    HomeComponent,
    SideNavTogglerComponent,
    SideNavComponent,
    LayoutComponent,
    TopNavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'sign-up', component: SignupFormComponent },
      { path: 'login', component: LoginFormComponent },
      { path: 'dashboard', component: LayoutComponent }
      
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
