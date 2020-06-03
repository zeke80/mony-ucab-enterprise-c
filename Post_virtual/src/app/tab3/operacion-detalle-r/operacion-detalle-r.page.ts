import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { OperacionService } from '../../servicios/operacion/operacion.service';
import { Reintegro } from '../../models/reintegro.model';
import { AlertController } from '@ionic/angular';


@Component({
  selector: 'app-operacion-detalle-r',
  templateUrl: './operacion-detalle-r.page.html',
  styleUrls: ['./operacion-detalle-r.page.scss'],
})
export class OperacionDetalleRPage implements OnInit {

  operacion: Reintegro;

  constructor(
    public _activatedRoute: ActivatedRoute,
    public _operacionServices: OperacionService,
    public alert: AlertController,
    public router: Router
  ) { }

  ngOnInit() {
    this._activatedRoute.paramMap.subscribe(paramMap => {
      const recipeID = paramMap.get('operacionID');
      let id: number = +recipeID;
      this.operacion = this._operacionServices.getreintegro(id);

    });
  }

  async aceptarReintegro() {
    const alertElement = await this.alert.create({
      header: '¿Esta seguro que quiere aceptar?',
      message: 'Va a aceptar el reintegro de la operacion',
      buttons: [
        {
          text: 'Aceptar',
          handler: () => {
            this.router.navigate(['/tabs/operaciones']);
          }
        },
        {
          text: 'Denegar',
          handler: () => {
            this.router.navigate(['/tabs/operaciones']);
          }
        },
        {
          text: 'Cancelar',
          role: 'cancelar'
        }
      ]
    });

    await alertElement.present();

  }


}
