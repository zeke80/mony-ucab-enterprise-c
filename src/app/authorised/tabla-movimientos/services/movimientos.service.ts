import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MovimientosService {

  show = false;

  constructor( private http : HttpClient) { }

  consultarCuentas(){
    let url = "http://monyucab.somee.com/api/Usuario/operacionesCuentas";

    let id = parseInt(localStorage.getItem('idUsuario'), 10);

    this.http.post(url, {'id' : id}).
    toPromise().then((data : any) =>{
    }
    )
    
    return this.http.post(url, {'id' : id});
  }

  consultarTarjeta (){
    let url = "http://monyucab.somee.com/api/Usuario/operacionesTarjetas";
    
    let id = parseInt(localStorage.getItem('idUsuario'), 10);

    this.http.post(url, {'id' : id}).
    toPromise().then((data : any) =>{
    }
    )

    return this.http.post(url, {'id' : id});
  }

  consutarMonedero (){
    let url = "http://monyucab.somee.com/api/Usuario/operacionesMonedero"

    let id = parseInt(localStorage.getItem('idUsuario'), 10);

    this.http.post(url, {'id' : id}).
    toPromise().then((data : any) =>{
    }
    )

    return this.http.post(url, {'id' : id});
  }

}
