import { Injectable } from '@angular/core';
import { OperacionCuenta } from '../../models/operacionCuenta.model';
import { OperacionMonedero } from '../../models/operacionMonedero.model';
import { OperacionTarjeta } from '../../models/operacionTarjeta.model';

@Injectable({
  providedIn: 'root'
})
export class OperacionService {

  operacionesCuenta: OperacionCuenta[] = [
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
    {
      idOperacionCuenta: 10,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '5:00 pm',
      monto: 5000000,
      referencia: 'Tremenda referencia'
    },
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
      idOperacionTarjeta: 1,
      idUsuarioReceptor: 2,
      idTarjeta: 1,
      fecha: '02/02/2020',
      hora: '02:49 pm',
      monto: 50,
      referencia: 'referencia'
    }
  ];

  constructor() { }

  getoperacionesCuenta() {

    return [...this.operacionesCuenta];

  }

  getoperacionesMonedero() {

    return [...this.operacionesMonedero];

  }

  getoperacionesTarjeta() {

    return [...this.operacionesTarjeta];

  }

  getoperacionCuenta(operacionID: number){
    return {
      ...this.operacionesCuenta.find(operacion => {
        return operacion.idOperacionCuenta === operacionID;
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
}
