import { Injectable } from '@angular/core';
import { Cuenta } from '../../models/cuenta.model';

@Injectable({
  providedIn: 'root'
})
export class CuentaService {

  cuentas: Cuenta[] = [
    {
      idCuenta: 1,
      idUsuario: 1,
      idTipoCuenta: 1,
      idBanco: 1,
      numero: '000000000'
    }
  ];

  constructor() { }

  getCuentas() {

    return [...this.cuentas];

  }

}
