import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { LoginService } from '../servicios/login/login.service';
import { Usuario } from '../models/usuario.model';
import { UsuarioService } from '../servicios/usuario/usuario.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  constructor(public router: Router,
              public _loginServices: LoginService,
              public _usuarioServices: UsuarioService) { }

  ngOnInit() {
  }

  ingresar( f: NgForm ) {
    this._loginServices.verificarUsuario(f.value.user, f.value.password)
              .subscribe((data: any) => {

              let usuario = new Usuario(data.idusuario, data.idtipousuario, data.idtipoidentificacion, data.usuario, data.fecha_registro,
                data.nro_identificacion, data.email, data.telefono, data.direccion, data.estatus);
              this._usuarioServices.guardarStorage(usuario, usuario.idUsuario, usuario.idTipoUsuario, usuario.usuario, usuario.fechaRegistro,
                usuario.nroIdentificacion, usuario.email, usuario.telefono, usuario.direccion);
              this.router.navigate(['/tabs/cuenta']);

            });
    // this.router.navigate(['/tabs/cuenta']);
  }

}
