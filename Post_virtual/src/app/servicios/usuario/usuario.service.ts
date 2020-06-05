import { Injectable } from '@angular/core';
import { Usuario } from '../../models/usuario.model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  public usuario: Usuario[] = [
    {
      idUsuario: 0,
      idTipoUsuario: 0,
      idTipoIdentificacion: 0,
      usuario: '',
      fechaRegistro: '',
      nroIdentificacion: 0,
      email: '',
      telefono: '',
      direccion: '',
      estatus: 0

    }
  ];

  constructor(
    public http: HttpClient
  ) { }

  getUsuario(idUsuario: number){
    return {
      ...this.usuario.find(usuario => {
        return usuario.idUsuario === idUsuario;
      })
    };
  }

  pruebaMony(){
    return this.http.get('http://monyucab.somee.com/WSMonyUCAB.svc/GetData?value=1234');
  }
}
