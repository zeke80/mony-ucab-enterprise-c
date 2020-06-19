import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Usuario } from '../../models/usuario.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';
import { PagoService } from '../../servicios/pago/pago.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pago',
  templateUrl: './pago.page.html',
  styleUrls: ['./pago.page.scss'],
})
export class PagoPage implements OnInit {

  usuario: Usuario
  pagos = [];
  aux: number;

  constructor(
    public _usuarioServices: UsuarioService,
    public _pagoSercives: PagoService,
    public router: Router
  ) { }

  ngOnInit() {
    this.usuario = this._usuarioServices.getUsuario();
  }

  realizarSolicitud( f: NgForm) {
    let cant: number = + f.value.monto;
    this._pagoSercives.solicitudPago(this.usuario.idUsuario, f.value.user, cant )
        .subscribe((data: any) => {
          this.aux = data;
          this._pagoSercives.getPagosSol(this.usuario.idUsuario)
              .subscribe((data: any) => {
                this.pagos = data;
                this._pagoSercives.guardarPagoSol(this.pagos);
                this.router.navigate(['/tabs/cuenta/pagoSinSolicitud', this.aux]);

              });
        });
  }

}
