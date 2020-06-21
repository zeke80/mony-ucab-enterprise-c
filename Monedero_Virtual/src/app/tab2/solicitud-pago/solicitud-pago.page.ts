import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Pago } from '../../models/pago.model';
import { PagoService } from '../../servicios/pago/pago.service';
import { UsuarioService } from '../../servicios/usuario/usuario.service';
import { Usuario } from '../../models/usuario.model';
import { CuentaService } from '../../servicios/cuenta/cuenta.service';
import { TarjetaService } from '../../servicios/tarjeta/tarjeta.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-solicitud-pago',
  templateUrl: './solicitud-pago.page.html',
  styleUrls: ['./solicitud-pago.page.scss'],
})
export class SolicitudPagoPage implements OnInit {

  operacion: Pago;
  usuario: Usuario;
  user: string;
  metodoPagoC = [];
  metodoPagoT = [];
  auxT = false;
  auxC = false;
  tarjeta: any;
  cuenta: any;

  constructor(
    public _activatedRoute: ActivatedRoute,
    public _pagoServices: PagoService,
    public _usuarioServices: UsuarioService,
    public _cuentaServices: CuentaService,
    public _tarjetaServices: TarjetaService,
    public router: Router
  ) { }

  ngOnInit() {
    this._activatedRoute.paramMap.subscribe(paramMap => {
      const recipeID = paramMap.get('pagoID');
      let id: number = +recipeID;
      this.operacion = this._pagoServices.getpago(id);
    });
    this._usuarioServices.inforUsurio(this.operacion.idusuario_solicitante)
        .subscribe((data: any) => {
          this.user = data.usuario;
        });
    this.usuario = this._usuarioServices.getUsuario();
    this._cuentaServices.getCuentas(this.usuario.idUsuario)
        .subscribe((data: any) => {
          console.log(data);
          this.metodoPagoC = data;
        });
    this._tarjetaServices.getTarjetas(this.usuario.idUsuario)
        .subscribe((data: any) => {
          this.metodoPagoT = data;
        });
  }

  boolTarjeta() {
    this.auxT = true;
    this.auxC = false;
  }

  boolCuenta() {
    this.auxC = true;
    this.auxT = false;
  }

  obtenerIDtajeta() {
  }

  obtenerIDcuenta() {
  }

  pagarTarjeta() {
    console.log('user del usuario receptor: ' + this.user);
    console.log('id tarjeta: ' + this.tarjeta);
    console.log('monto: ' + this.operacion.monto);
    console.log('referencia: ' + this.operacion.referencia);
    
    let id: number = + this.tarjeta;
    let ref: number = + this.operacion.referencia
    let cant: number = + this.operacion.monto;

    this._pagoServices.pagoTarjeta(id, this.user, cant, ref)
        .subscribe((data: any) => {
          this.router.navigate(['/tabs/cuenta']);
        });

  }

  pagarCuenta() {
    console.log('user del usuario receptor: ' + this.user);
    console.log('id cuenta: ' + this.cuenta);
    console.log('monto: ' + this.operacion.monto);
    console.log('referencia: ' + this.operacion.referencia);
    let id: number = + this.cuenta;
    let ref: number = + this.operacion.referencia
    let cant: number = + this.operacion.monto;

    this._pagoServices.pagoCuenta(id, this.user, cant, ref)
        .subscribe((data: any) => {
          this.router.navigate(['/tabs/cuenta']);
        });
  }

  pagarMonedero() {
    console.log('hola');
    let ref: number = + this.operacion.referencia;
    let cant: number = + this.operacion.monto;
    this._pagoServices.pagoMonedero(this.operacion.idusuario_receptor, this.user, cant, ref)
        .subscribe((data: any) => {
          this.router.navigate(['/tabs/cuenta']);
        });
  }


}
