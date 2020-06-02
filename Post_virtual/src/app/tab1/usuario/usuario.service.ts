import { Injectable } from '@angular/core';
import { Usuario } from '../../models/usuario.model';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  public usuario: Usuario[] = [
    {
      idUsuario: 1,
      idTipoUsuario: 1,
      idTipoIdentificacion: 1,
      usuario: 'rojocadi22',
      fechaRegistro: '02/02/2020',
      nroIdentificacion: 26411292,
      email: 'robertocd/98@gmail.com',
      telefono: '04140315625',
      direccion: 'Sabana grande',
      estatus: 1

    }
  ];

  constructor() { }

  getUsuario(idUsuario: number){
    return {
      ...this.usuario.find(usuario => {
        return usuario.idUsuario === idUsuario;
      })
    };
  }
}
