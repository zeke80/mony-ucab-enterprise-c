import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Usuario } from '../../models/usuario.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';

@Component({
  selector: 'app-pago',
  templateUrl: './pago.page.html',
  styleUrls: ['./pago.page.scss'],
})
export class PagoPage implements OnInit {

  usuario: Usuario

  constructor(
    public _usuarioServices: UsuarioService
  ) { }

  ngOnInit() {
    this.usuario = this._usuarioServices.getUsuario();
  }

  realizarSolicitud( f: NgForm) {
    console.log(f);
    console.log(this.usuario.idUsuario);
  }

}
