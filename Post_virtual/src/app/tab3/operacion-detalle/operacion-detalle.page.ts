import { Component, OnInit } from '@angular/core';
import { OperacionService } from '../../servicios/operacion/operacion.service';
import { ActivatedRoute, Router } from '@angular/router';
import { OperacionCuenta } from '../../models/operacionCuenta.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';
import { CuentaService } from '../../servicios/cuenta/cuenta.service';


@Component({
  selector: 'app-operacion-detalle',
  templateUrl: './operacion-detalle.page.html',
  styleUrls: ['./operacion-detalle.page.scss'],
})
export class OperacionDetallePage implements OnInit {

  operacion: OperacionCuenta;
  user: string;
  nroCuenta: string;

  constructor(
    public _operacionServices: OperacionService,
    public _activatedRoute: ActivatedRoute,
    public _usuarioServices: UsuarioService,
    public _cuentaServices: CuentaService
  ) { }

  ngOnInit() {

    this._activatedRoute.paramMap.subscribe(paramMap => {
      const recipeID = paramMap.get('operacionID');
      let id: number = +recipeID;
      this.operacion = this._operacionServices.getoperacionCuenta(id);
    });
    this._usuarioServices.inforUsurio(this.operacion.idusuarioreceptor)
        .subscribe((data: any) => {
          this.user = data.usuario;
        });
    this._cuentaServices.infoCuenta(this.operacion.idcuenta)
        .subscribe((data: any) => {
          this.nroCuenta = data.numero;
        });

  }

}
