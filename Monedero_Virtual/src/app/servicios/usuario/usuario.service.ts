import { Injectable } from '@angular/core';
import { Usuario } from '../../models/usuario.model';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  public usuario: Usuario[] = [
    {
      idUsuario: 1,
      idTipoUsuario: 0,
      idTipoIdentificacion: 0,
      usuario: 'hola',
      fechaRegistro: '',
      nroIdentificacion: 0,
      email: '',
      telefono: '',
      direccion: '',
      estatus: 0

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
