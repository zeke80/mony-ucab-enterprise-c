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
      idOperacionCuenta: 1,
      idCuenta: 1,
      idUsuarioReceptor: 2,
      fecha: '02/02/2020',
      hora: '12:02 am',
      monto: 1000,
      referencia: 'no se referencia xD'
    }
  ];
  operacionesMonedero: OperacionMonedero[] = [
    {
      idOperacionMonedero: 1,
      idUsuario: 1,
      idTipoOperacion: 1,
      monto: 10000,
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
}
