import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(
    public http: HttpClient
  ) { }

  verificarUsuario(user: string, contra: string) {

    let url: string = 'http://monyucab.somee.com/api/Usuario/loginPersona';

    let data = {
      "user": user,
      "contra": contra
    };

    return this.http.post(url, data);

  }
  
}
