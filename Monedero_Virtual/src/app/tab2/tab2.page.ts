import { Component, OnInit } from '@angular/core';
import { CuentaService } from '../servicios/cuenta/cuenta.service';
import { TarjetaService } from '../servicios/tarjeta/tarjeta.service';
import { UsuarioService } from '../servicios/usuario/usuario.service';
import { Usuario } from '../models/usuario.model';
import { PagoService } from '../servicios/pago/pago.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page implements OnInit{

  tarjetas = [];
  cuentas = [];
  pagos = [];
  usuario: Usuario;

  constructor(
    public _cuentaServices: CuentaService,
    public _tarjetaService: TarjetaService,
    public _usuarioService: UsuarioService,
    public _pagoServices: PagoService,
    public router: Router,
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

  solicitudPago() {
    this.router.navigate(['tabs/cuenta/pago']);
  }

}
