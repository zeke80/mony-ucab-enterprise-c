import { Component, OnInit } from '@angular/core';
import { PagoService } from '../../servicios/pago/pago.service';
import { Usuario } from '../../models/usuario.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';

@Component({
  selector: 'app-cierre',
  templateUrl: './cierre.page.html',
  styleUrls: ['./cierre.page.scss'],
})
export class CierrePage implements OnInit {

  pagos = [];
  usuario: Usuario;

  constructor(
    public _usuarioService: UsuarioService,
    public _pagoServices: PagoService
  ) { }

  ngOnInit() {
    this.usuario = this._usuarioService.getUsuario();
    this.pagos = this._pagoServices.getVacio();
    this._pagoServices.getPagos(this.usuario.idUsuario)
        .subscribe((data: any) => {
          this.pagos = data;
          this._pagoServices.guardarPago(this.pagos);
        });
        
  }

}
