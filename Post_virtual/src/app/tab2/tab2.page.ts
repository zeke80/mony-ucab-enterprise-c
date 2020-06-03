import { Component, OnInit } from '@angular/core';
import { CuentaService } from '../servicios/cuenta/cuenta.service';
import { TarjetaService } from '../servicios/tarjeta/tarjeta.service';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page implements OnInit {

  cuentas = [];
  tarjetas = [];

  constructor(
    public _cuentaServices: CuentaService,
    public _tarjetaService: TarjetaService
  ) {}

  ngOnInit(){
    this.cuentas = this._cuentaServices.getCuentas();
    this.tarjetas = this._tarjetaService.getTarjetas();
  }

}
