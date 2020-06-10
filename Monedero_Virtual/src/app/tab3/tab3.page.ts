import { Component,  OnInit } from '@angular/core';
import { OperacionService } from '../servicios/operacion/operacion.service';


@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page implements OnInit{

  cuentas = [];
  tarjetas = [];
  monederos = [];
  reintegros = [];

  constructor(
    public _operacionServices: OperacionService
  ) {}

  ngOnInit(){
    this.cuentas = this._operacionServices.getoperacionesCuenta();
    this.tarjetas = this._operacionServices.getoperacionesTarjeta();
    this.monederos = this._operacionServices.getoperacionesMonedero();
    this.reintegros = this._operacionServices.getreintegros();
  }

}
