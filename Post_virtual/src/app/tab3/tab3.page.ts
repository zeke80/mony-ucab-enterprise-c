import { Component, OnInit } from '@angular/core';
import { OperacionService } from '../servicios/operacion/operacion.service';
import { Router } from '@angular/router';
import { Usuario } from '../models/usuario.model';
import { UsuarioService } from '../servicios/usuario/usuario.service';

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
  usuario: Usuario

  constructor(
    public _operacionServices: OperacionService,
    public router: Router,
    public _usuarioServices: UsuarioService
  ) {}

  ngOnInit(){
    this.cuentas = this._operacionServices.getoperacionesCuentaVacio();
    this.tarjetas = this._operacionServices.getoperacionesTarjetaVacio();
    this.monederos = this._operacionServices.getoperacionesMonederoVacio();
    this.reintegros = this._operacionServices.getreintegrosVacio();
    this.usuario = this._usuarioServices.getUsuario();
    this._operacionServices.getoperacionesCuenta(this.usuario.idUsuario)
        .subscribe((data: any) => {
          this.cuentas = data;
          this._operacionServices.guardarCuentas(this.cuentas);
        });
    this._operacionServices.getoperacionesTarjeta(this.usuario.idUsuario)
        .subscribe((data: any) => {
          this.tarjetas = data;
          this._operacionServices.guardarTarjetas(this.tarjetas);

        });
  }

  solicitudPago() {
    this.router.navigate(['tabs/operaciones/pago']);
  }

}
