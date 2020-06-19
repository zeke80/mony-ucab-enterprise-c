import { Component, OnInit } from '@angular/core';
import { CuentaService } from '../servicios/cuenta/cuenta.service';
import { TarjetaService } from '../servicios/tarjeta/tarjeta.service';
import { Usuario } from '../models/usuario.model';
import { UsuarioService } from '../servicios/usuario/usuario.service';
import { PagoService } from '../servicios/pago/pago.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page implements OnInit {

  cuentas = [];
  tarjetas = [];
  pagos = [];
  usuario: Usuario

  constructor(
    public _cuentaServices: CuentaService,
    public _tarjetaService: TarjetaService,
    public _usuarioService: UsuarioService,
    public _pagoServices: PagoService,
    public _activatedRoute: ActivatedRoute
  ) {
    this._activatedRoute.paramMap.subscribe(params => {
      this.ngOnInit();
  });
  }

  ngOnInit(){
    this.usuario = this._usuarioService.getUsuario();

    this.cuentas = this._cuentaServices.getVacio();
    this._cuentaServices.getCuentas(this.usuario.idUsuario)
         .subscribe((data: any) => {
           console.log(data);
           this.cuentas = data;
         });
    this.tarjetas = this._tarjetaService.getVacio();
    this._tarjetaService.getTarjetas(this.usuario.idUsuario)
         .subscribe((data: any) => {
           this.tarjetas = data;
         });
    this.pagos = this._pagoServices.getVacio();
    this._pagoServices.getPagos(this.usuario.idUsuario)
        .subscribe((data: any) => {
          this.pagos = data;
          this._pagoServices.guardarPago(this.pagos);
        });
  }

  

}
