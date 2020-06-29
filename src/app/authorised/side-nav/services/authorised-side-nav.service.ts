import { Injectable } from '@angular/core';

import { BloquearService } from './../../bloquear/services/bloquear.service';
import { MovimientosService } from './../../tabla-movimientos/services/movimientos.service';
import { PerfilService } from './../../perfil/services/perfil.service';
import { TransferirService } from './../../transferir-card/services/transferir.service';
import { ProductosService } from './../../productos/services/productos.service';
import { ConfiguracionesService } from './../../configuraciones/services/configuraciones.service';

@Injectable({
  providedIn: 'root'
})
export class AuthorisedSideNavService {
  hideSideNav: boolean = false;
 
  constructor(private s_movimientos : MovimientosService,
    private s_bloquear : BloquearService,
    private s_perfil : PerfilService,
    private s_transferir : TransferirService,
    private s_configuraciones : ConfiguracionesService,
    private s_productos : ProductosService) { }
 
  toggleSideNav(): void {
    this.hideSideNav = !this.hideSideNav;
  }

  toggleMovimientos(){
    this.s_movimientos.show = true;
    this.s_bloquear.show = false;
    this.s_perfil.show = false;
    this.s_transferir.show = false;
    this.s_configuraciones.show = false;
    this.s_productos.show = false;
  }

  toggleBloquear(){
    this.s_bloquear.show = true;
    this.s_movimientos.show = false;
    this.s_perfil.show = false;
    this.s_transferir.show = false;
    this.s_configuraciones.show = false;
    this.s_productos.show = false;
  }

  togglePerfil(){
    this.s_perfil.show = true;
    this.s_movimientos.show = false;
    this.s_bloquear.show = false;
    this.s_transferir.show = false;
    this.s_configuraciones.show = false;
    this.s_productos.show = false;
  }

  toggleTransferir(){
    this.s_transferir.show = true;
    this.s_movimientos.show = false;
    this.s_bloquear.show = false;
    this.s_perfil.show = false;
    this.s_configuraciones.show = false;
    this.s_productos.show = false;
  }

  toggleConfiguraciones(){
    this.s_configuraciones.show = true;
    this.s_movimientos.show = false;
    this.s_bloquear.show = false;
    this.s_perfil.show = false;
    this.s_transferir.show = false;
    this.s_productos.show = false;
  }

  toogleProductos(){
    this.s_productos.show = true;
    this.s_configuraciones.show = false;
    this.s_movimientos.show = false;
    this.s_bloquear.show = false;
    this.s_perfil.show = false;
    this.s_transferir.show = false;

  }
}