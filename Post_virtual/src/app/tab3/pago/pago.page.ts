import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Usuario } from '../../models/usuario.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';
import { PagoService } from '../../servicios/pago/pago.service';
import { Router } from '@angular/router';
import { AlertController } from '@ionic/angular';

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

}
