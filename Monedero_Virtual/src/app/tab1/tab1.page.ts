import { Component, OnInit } from '@angular/core';
import { UsuarioService } from '../servicios/usuario/usuario.service';
import { Usuario } from '../models/usuario.model';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page implements OnInit {

  usuario: Usuario

  constructor(
    public _usuarioServices: UsuarioService
  ) {}

  ngOnInit(){
    this.usuario = this._usuarioServices.getUsuario(1);
  }

  modificarUsuario( f: NgForm){
    console.log(f.value.user)
  }

}
