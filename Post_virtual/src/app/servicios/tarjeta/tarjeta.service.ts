import { Injectable } from '@angular/core';
import { Tarjeta } from '../../models/tarjeta.model';

@Injectable({
  providedIn: 'root'
})
export class TarjetaService {

  tarjetas: Tarjeta[] = [
    {
      idTarjeta: 1,
      idUsuario: 1,
      idTipoTarjeta: 1,
      idBanco: 1,
      numero: 15235795,
      fechaVencimineto: '02/02/2020',
      cvc: 1,
      estatus: 1
    },
    {
      idTarjeta: 1,
      idUsuario: 1,
      idTipoTarjeta: 1,
      idBanco: 1,
      numero: 15235795,
      fechaVencimineto: '02/02/2020',
      cvc: 1,
      estatus: 1
    },
    {
      idTarjeta: 1,
      idUsuario: 1,
      idTipoTarjeta: 1,
      idBanco: 1,
      numero: 15235795,
      fechaVencimineto: '02/02/2020',
      cvc: 1,
      estatus: 1
    },
    {
      idTarjeta: 1,
      idUsuario: 1,
      idTipoTarjeta: 1,
      idBanco: 1,
      numero: 15235795,
      fechaVencimineto: '02/02/2020',
      cvc: 1,
      estatus: 1
    },
  ]

  constructor() { }

  getTarjetas() {

    return [...this.tarjetas];

  }
}
