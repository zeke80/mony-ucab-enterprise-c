import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { LoginService } from './home/login-form/services/login.service';
import { AuthorisedSideNavService } from './authorised/side-nav/services/authorised-side-nav.service';
import { MovimientosService } from './authorised/tabla-movimientos/services/movimientos.service';
import { BloquearService } from './authorised/bloquear/services/bloquear.service';
import { PerfilService } from './authorised/perfil/services/perfil.service';
import { TransferirService } from './authorised/transferir-card/services/transferir.service';
import { ConfiguracionesService } from './authorised/configuraciones/services/configuraciones.service';

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
import { BloquearComponent } from './authorised/bloquear/bloquear.component';
import { TablaMovimientosComponent } from './authorised/tabla-movimientos/tabla-movimientos.component';
import { TransferirCardComponent } from './authorised/transferir-card/transferir-card.component';
import { PerfilComponent } from './authorised/perfil/perfil.component';
import { ConfiguracionesComponent } from './authorised/configuraciones/configuraciones.component';

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
    TopNavComponent,
    BloquearComponent,
    TablaMovimientosComponent,
    TransferirCardComponent,
    PerfilComponent,
    ConfiguracionesComponent
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
  providers: [
    LoginService, 
    AuthorisedSideNavService,
    MovimientosService,
    BloquearService,
    PerfilService,
    TransferirService,
    ConfiguracionesService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
