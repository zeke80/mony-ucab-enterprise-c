import { Injectable } from '@angular/core';
import { Comercio } from '../../models/comercio.model';

@Injectable({
  providedIn: 'root'
})
export class ComercioService {

  public comercio: Comercio[] = [
    {
      idUsurio: 1,
      razonSocial: 'Comida',
      nombreRepresentante: 'Roberto',
      apellidoRepresentante: 'Carbajales'
    }
  ];

  constructor() { }

  getComercio(idUsuario: number){
    return {
      ...this.comercio.find(comercio => {
        return comercio.idUsurio === idUsuario;
      })
    };
  }
}
