import { Component, OnInit } from '@angular/core';
import { LoginService } from './services/login.service';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import {HttpErrorResponse} from '@angular/common/http'; 
import { Usuario } from './../../models/usuario.model';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  user: String;
  contra :String;

  constructor(public service: LoginService, public router: Router) { }

  ngOnInit(): void {
  }

  ingresarPersona(){
    this.service.loginPersona(this.user,this.contra)
    .subscribe(
      (data: any) => {
        let usuario = new Usuario (data.idusuario, data.idtipousuario, data.idtipoidentificacion, data.usuario, data.fecha_registro,
          data.nro_identificacion, data.email, data.telefono, data.direccion, data.estatus);

          this.service.guardarUsuario(usuario, usuario.idUsuario, usuario.idTipoUsuario, usuario.idTipoIdentificacion, usuario.usuario,
            usuario.fechaRegistro, usuario.nroIdentificacion, usuario.email, usuario.telefono, usuario.direccion, usuario.estatus);
      this.router.navigate(['/dashboard'])
    },
      (error : HttpErrorResponse) => {
        if (error.status == 404){
          alert("Usuario no encontrado.")
        }
        else{
          alert("Ha ocurrido un error. Intente de nuevo")
        }
      }
    );
  }

  ingresarComercio(){
    this.service.loginComercio(this.user,this.contra)
    .subscribe(
      (data: any) => {
        
        let usuario = new Usuario (data.idusuario, data.idtipousuario, data.idtipoidentificacion, data.usuario, data.fecha_registro,
          data.nro_identificacion, data.email, data.telefono, data.direccion, data.estatus);

          this.service.guardarUsuario(usuario, usuario.idUsuario, usuario.idTipoUsuario, usuario.idTipoIdentificacion, usuario.usuario,
            usuario.fechaRegistro, usuario.nroIdentificacion, usuario.email, usuario.telefono, usuario.direccion, usuario.estatus);
      this.router.navigate(['/dashboard'])
    },
      (error : HttpErrorResponse) => {
        if (error.status == 404){
          alert("Usuario no encontrado.")
        }
        else{
          alert("Ha ocurrido un error. Intente de nuevo")
        }
      }
    );
  }
}
