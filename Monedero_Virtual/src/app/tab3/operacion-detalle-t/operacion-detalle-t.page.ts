import { Component, OnInit } from '@angular/core';
import { OperacionService } from '../../servicios/operacion/operacion.service';
import { ActivatedRoute, Router } from '@angular/router';
import { OperacionTarjeta } from '../../models/operacionTarjeta.model';
import { UsuarioService } from '../../servicios/usuario/usuario.service';
import { CuentaService } from '../../servicios/cuenta/cuenta.service';
import { Usuario } from '../../models/usuario.model';

@Component({
  selector: 'app-operacion-detalle-t',
  templateUrl: './operacion-detalle-t.page.html',
  styleUrls: ['./operacion-detalle-t.page.scss'],
})
export class OperacionDetalleTPage implements OnInit {

  operacion: OperacionTarjeta;
  user: string;
  nrotarjeta: string;
  idreceptor: number;
  usuario: Usuario;

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
      this.operacion = this._operacionServices.getoperacionTarjeta(id);
    });
    this.usuario = this._usuarioServices.getUsuario();
    this._usuarioServices.inforUsurio(this.operacion.idusuarioreceptor)
    .subscribe((data: any) => {
      this.user = data.usuario;
      this.idreceptor = data.idusuario;
    });
    this._cuentaServices.infoCuenta(this.operacion.idtarjeta)
        .subscribe((data: any) => {
          this.nrotarjeta = data.numero;
        });
  }

  SolicitarReintegro() {
    console.log('id del usuario solicitante: ' + this.usuario.idUsuario);
    console.log('id usuario receptor: ' + this.idreceptor);
    console.log('referencia:' + this.operacion.referencia);
  }

}
