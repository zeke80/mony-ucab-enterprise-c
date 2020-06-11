import { Injectable } from '@angular/core';
import { OperacionCuenta } from '../../models/operacionCuenta.model';
import { OperacionMonedero } from '../../models/operacionMonedero.model';
import { OperacionTarjeta } from '../../models/operacionTarjeta.model';
import { Reintegro } from '../../models/reintegro.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class OperacionService {

  operacionesCuenta: OperacionCuenta[] = [
    {
      idoperacioncuenta: 0,
      idCuenta: 0,
      idUsuarioReceptor: 0,
      fecha: '',
      hora: '',
      monto: 0,
      referencia: ''
    }
  ];
  operacionesMonedero: OperacionMonedero[] = [
    {
      idOperacionMonedero: 0,
      idUsuario: 0,
      idTipoOperacion: 0,
      monto: 0,
      fecha: '',
      hora: '',
      referencia: ''
    }
  ];
  operacionesTarjeta: OperacionTarjeta[] = [
    {
      idoperaciontarjeta: 0,
      idUsuarioReceptor: 0,
      idTarjeta: 0,
      fecha: '',
      hora: '',
      monto: 0,
      referencia: ''
    }
  ];

  reintegros: Reintegro[] = [
    {
      idReintegro: 0,
      idUsuarioSolicitante: 0,
      idUsuarioReceptor: 0,
      fecha_solicitud: '',
      referencia: '',
      status: ''
    }
  ];

  constructor(
    public http: HttpClient
  ) { }

  getoperacionesCuentaVacio() {

    return [...this.operacionesCuenta];

  }

  getoperacionesMonederoVacio() {

    return [...this.operacionesMonedero];

  }

  getoperacionesTarjetaVacio() {

    return [...this.operacionesTarjeta];

  }

  getreintegrosVacio() {

    return [...this.reintegros];

  }

  guardarCuentas(cuentas: OperacionCuenta[]) {
    this.operacionesCuenta = cuentas;
  }

  guardarTarjetas(tarjeta: OperacionTarjeta[]) {
    this.operacionesTarjeta = tarjeta;
  }

  getoperacionesCuenta(idusuario: number) {
    let url: string = 'http://monyucab.somee.com/api/Usuario/operacionesCuenta';

    let data = {
      "id" : idusuario
    };


    return this.http.post(url, data);
  }

  getoperacionesTarjeta(idusuario: number) {
    let url: string = 'http://monyucab.somee.com/api/Usuario/operacionesTarjeta';

    let data = {
      "id" : idusuario
    };

    return this.http.post(url, data);
  }

  getoperacionCuenta(operacionID: number){
    return {
      ...this.operacionesCuenta.find(operacion => {
        return operacion.idoperacioncuenta === operacionID;
      })
    };
  }

  getoperacionMonedero(operacionID: number){
    return {
      ...this.operacionesMonedero.find(operacion => {
        return operacion.idOperacionMonedero === operacionID;
      })
    };
  }

  getoperacionTarjeta(operacionID: number){
    return {
      ...this.operacionesTarjeta.find(operacion => {
        return operacion.idoperaciontarjeta === operacionID;
      })
    };
  }

  getreintegro(operacionID: number){
    return {
      ...this.reintegros.find(operacion => {
        return operacion.idReintegro === operacionID;
      })
    };
  }

}
