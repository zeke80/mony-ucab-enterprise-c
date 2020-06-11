import { Component, OnInit } from '@angular/core';
import { OperacionService } from '../../servicios/operacion/operacion.service';
import { ActivatedRoute, Router } from '@angular/router';
import { OperacionCuenta } from '../../models/operacionCuenta.model';
@Component({
  selector: 'app-operacion-detalle',
  templateUrl: './operacion-detalle.page.html',
  styleUrls: ['./operacion-detalle.page.scss'],
})
export class OperacionDetallePage implements OnInit {

  operacion: OperacionCuenta;

  constructor(
    public _operacionServices: OperacionService,
    public _activatedRoute: ActivatedRoute,
  ) { }

  ngOnInit() {

    this._activatedRoute.paramMap.subscribe(paramMap => {
      const recipeID = paramMap.get('operacionID');
      let id: number = +recipeID;
      this.operacion = this._operacionServices.getoperacionCuenta(id);
    });

  }

}
