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
    console.log(user);
    console.log(contra);

    let url: string = 'http://monyucab.somee.com/WSMonyUCAB.svc/login';

    return this.http.post(url, [user, contra]);

  }
}
