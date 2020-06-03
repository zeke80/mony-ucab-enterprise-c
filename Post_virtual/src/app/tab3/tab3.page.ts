import { Component, OnInit } from '@angular/core';
import { OperacionService } from '../servicios/operacion/operacion.service';
import { Router } from '@angular/router';

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
    public _operacionServices: OperacionService,
    public router: Router
  ) {}

  ngOnInit(){
    this.cuentas = this._operacionServices.getoperacionesCuenta();
    this.tarjetas = this._operacionServices.getoperacionesTarjeta();
    this.monederos = this._operacionServices.getoperacionesMonedero();
    this.reintegros = this._operacionServices.getreintegros();
  }

  solicitudPago() {
    this.router.navigate(['tabs/operaciones/pago']);
  }

}
