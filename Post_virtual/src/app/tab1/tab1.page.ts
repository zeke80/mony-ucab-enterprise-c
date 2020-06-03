import { Component, OnInit } from '@angular/core';
import { Usuario } from '../models/usuario.model';
import { UsuarioService } from './usuario/usuario.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page implements OnInit {

  usuario: Usuario;

  constructor(
    public _usuarioService: UsuarioService
  ) {
  }

  ngOnInit(){
    this.usuario = this._usuarioService.getUsuario(1);
  }

  modificarUsuario( f: NgForm) {
    console.log(f.value.user);
  }

}
