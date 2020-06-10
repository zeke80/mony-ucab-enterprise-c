import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Usuario } from '../models/usuario.model';
import { Comercio } from '../models/comercio.model';
import { UsuarioService } from '../servicios/usuario/usuario.service';
import { ComercioService } from '../servicios/comercio/comercio.service';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page implements OnInit {

  usuario: Usuario;
  comercio: Comercio;

  constructor(
    public _usuarioService: UsuarioService,
    public _comercioService: ComercioService
  ) {
  }

  ngOnInit(){
    this.usuario = this._usuarioService.getUsuario();
    this.comercio = this._comercioService.getVacio();
    this._comercioService.getComercio(this.usuario.idUsuario)
                  .subscribe((data: any) => {
                    this.comercio = data;
                  });
  }

  modificarUsuario( f: NgForm) {
    console.log(f);
  }

}
