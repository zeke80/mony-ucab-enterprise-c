import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { LoginService } from '../servicios/login/login.service';
import { Usuario } from '../models/usuario.model';
import { UsuarioService } from '../servicios/usuario/usuario.service';
import { HttpErrorResponse } from '@angular/common/http';
import { AlertController } from '@ionic/angular';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  constructor(public router: Router,
              public _loginServices: LoginService,
              public _usuarioServices: UsuarioService,
              public alert: AlertController,
              ) { }

  ngOnInit() {
  }

  ingresar( f: NgForm ) {
    this._loginServices.verificarUsuario(f.value.user, f.value.password)
              .subscribe((data: any) => {

               let fecha =  data.fecha_registro.split('T', 1);

              let usuario = new Usuario(data.idusuario, data.idtipousuario, data.idtipoidentificacion, data.usuario, fecha,
                data.nro_identificacion, data.email, data.telefono, data.direccion, data.estatus);
              this._usuarioServices.guardarStorage(usuario, usuario.idUsuario, usuario.idTipoUsuario, usuario.usuario, usuario.fechaRegistro,
                usuario.nroIdentificacion, usuario.email, usuario.telefono, usuario.direccion);
              this.router.navigate(['/tabs/cuenta']);

            },
            (error: HttpErrorResponse) => {
              this.AlertaError();
            });
  }

  async AlertaError() {
    const alertElement = await this.alert.create({
      header: 'Error en login',
      message: 'Usuario y/o clave incorrectas ',
      buttons: [
        {
          text: 'Aceptar',
          handler: () => {
            this.router.navigate(['/login']);
          }
        },

      ]
    });

    await alertElement.present();

  }

}
