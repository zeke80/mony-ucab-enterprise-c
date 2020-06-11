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
      idoperacioncuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    }
  ];
  operacionesMonedero: OperacionMonedero[] = [
    {
      idOperacionMonedero: 123,
      idUsuario: 1,
      idTipoOperacion: 1,
      monto: 100000,
      fecha: '02/02/2020',
      hora: '01:30 pm',
      referencia: 'referencia'
    }
  ];
  operacionesTarjeta: OperacionTarjeta[] = [
    {
      idoperaciontarjeta: 1,
      idUsuarioReceptor: 2,
      idTarjeta: 1,
      fecha: '02/02/2020',
      hora: '02:49 pm',
      monto: 50,
      referencia: 'referencia'
    }
  ];

  reintegros: Reintegro[] = [
    {
      idReintegro: 1,
      idUsuarioSolicitante: 1,
      idUsuarioReceptor: 1,
      fecha_solicitud: '02/02/2020',
      referencia: 'referencia',
      status: 'solicitado'
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
