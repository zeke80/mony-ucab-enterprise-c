import { MovimientosService } from './../../tabla-movimientos/services/movimientos.service';

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthorisedSideNavService {
  hideSideNav: boolean = false;
 
  constructor(public s_movimientos : MovimientosService) { }
 
  toggleSideNav(): void {
    this.hideSideNav = !this.hideSideNav;
  }

}
