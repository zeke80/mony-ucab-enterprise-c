import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Pago } from '../../models/pago.model';

@Injectable({
  providedIn: 'root'
})
export class PagoService {

  public pagos: Pago[] = [
    {
      idpago: 0,
      idusuariosolicitante: 1,
      idusuarioreceptor: 1,
      fechasolicitud: '01/01/2020',
      monto: 0,
      estatus: '1'
    }
  ];

  constructor(
    public http: HttpClient
  ) { }

  getVacio() {
    return [...this.pagos];
  }
}
