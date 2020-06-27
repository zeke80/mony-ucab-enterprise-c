import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Usuario } from './../../../models/usuario.model';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

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
  
  constructor(private http: HttpClient) { }

  loginPersona(usuario:String, contrasena:String){
    let url= "http://monyucab.somee.com/api/Usuario/loginPersona"
    this.http.post(url, 
      {user: usuario, contra: contrasena}).
      toPromise().then((data : any) =>{
      }
      )
      return this.http.post(url, {user: usuario, contra: contrasena});
  }

  loginComercio(usuario:String, contrasena:String){
    let url= "http://monyucab.somee.com/api/Usuario/loginComercio"
    this.http.post(url, 
      {user: usuario, contra: contrasena}).
      toPromise().then((data : any) =>{
      }
      )

      return this.http.post(url, {user: usuario, contra: contrasena});
  }

  guardarUsuario( newUsuario : Usuario, 
     idUsuario : number,
     idTipoUsuario : number,
     idTipoIdentificacion : number,
     usuario : string,
     fechaRegistro : string,
     nroIdentificacion : number,
     email : string,
     telefono : string,
     direccion : string,
     estatus : number){

        localStorage.setItem('idUsuario', idUsuario.toString());
        localStorage.setItem('idTipoUsuario', idTipoUsuario.toString());
        localStorage.setItem('idTipoIdentificacion', idTipoIdentificacion.toString());
        localStorage.setItem('usuario', usuario);
        localStorage.setItem('fechaRegistro', fechaRegistro);
        localStorage.setItem('nroIdentificacion', nroIdentificacion.toString());
        localStorage.setItem('email', email);
        localStorage.setItem('telefono',telefono);
        localStorage.setItem('direccion', direccion);
        localStorage.setItem('estatus', estatus.toString());
     
      this.usuario[0] = newUsuario;

  }
}
