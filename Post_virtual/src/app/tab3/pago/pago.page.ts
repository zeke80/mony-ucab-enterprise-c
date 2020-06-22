import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Usuario } from '../../models/usuario.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';
import { PagoService } from '../../servicios/pago/pago.service';
import { Router } from '@angular/router';
import { AlertController } from '@ionic/angular';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-pago',
  templateUrl: './pago.page.html',
  styleUrls: ['./pago.page.scss'],
})
export class PagoPage implements OnInit {

  usuario: Usuario

  constructor(
    public _usuarioServices: UsuarioService,
    public _pagoSercives: PagoService,
    public router: Router,
    public alert: AlertController,
  ) { }

  ngOnInit() {
    this.usuario = this._usuarioServices.getUsuario();
  }

  realizarSolicitud( f: NgForm) {
    let cant: number = + f.value.monto;
    this._pagoSercives.solicitudPago(this.usuario.idUsuario, f.value.user, cant )
        .subscribe((data: any) => {
          this.realizarSol();
        },
        (error: HttpErrorResponse) => {
          if (error.status === 409) {
            this.AlertServer();
          }
          else {
            this.AlertaError();
          }
        });
  }

  async realizarSol() {
    const alertElement = await this.alert.create({
      header: 'Notificacion',
      message: 'se manda la solicitud de pago',
      buttons: [
        {
          text: 'Aceptar',
          handler: () => {
            this.router.navigate(['/tabs/operaciones']);
          }
        }
      ]
    });

    await alertElement.present();

  }

  async AlertaError() {
    const alertElement = await this.alert.create({
      header: 'Error al realizar apgo',
      message: 'El usuario no existe en el sistema',
      buttons: [
        {
          text: 'Aceptar',
          handler: () => {
          }
        },
      ]
    });

    await alertElement.present();

  }

  async AlertServer() {
    const alertElement = await this.alert.create({
      header: 'Error inesperado',
      message: 'intentelo mas tarde',
      buttons: [
        {
          text: 'Aceptar',
          handler: () => {
          }
        },

      ]
    });

    await alertElement.present();

  }

}
