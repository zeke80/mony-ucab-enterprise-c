import { Component, OnInit } from '@angular/core';
import { UsuarioService } from '../servicios/usuario/usuario.service';
import { Usuario } from '../models/usuario.model';
import { NgForm } from '@angular/forms';
import { PersonaService } from '../servicios/persona/persona.service';
import { Persona } from '../models/persona.model';

@Component({
  selector: 'app-tab1',
  templateUrl: 'tab1.page.html',
  styleUrls: ['tab1.page.scss']
})
export class Tab1Page implements OnInit {

  usuario: Usuario;
  persona: Persona;

  constructor(
    public _usuarioServices: UsuarioService,
    public _personaServices: PersonaService
  ) {}

  ngOnInit(){
    this.usuario = this._usuarioServices.getUsuario();
    this.persona = this._personaServices.getVacio();
    this._personaServices.getPersona(this.usuario.idUsuario)
        .subscribe((data: any) => {
          this.persona = data;
        })
  }

  modificarUsuario( f: NgForm){
    console.log(f.value.user);
  }

}
