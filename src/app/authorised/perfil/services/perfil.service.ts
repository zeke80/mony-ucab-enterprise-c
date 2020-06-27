import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PerfilService {

  show = false;
  
  constructor(private http : HttpClient) {
  }

  consultarUSuario(){
    let url = "http://monyucab.somee.com/api/Usuario/infoUsuario";

    let id = parseInt(localStorage.getItem('idUsuario'), 10);

    this.http.post(url, {'id' : id}).
    toPromise().then((data : any) =>{
    }
    )
    
    return this.http.post(url, {'id' : id});

  }

  consultarPersona(){
    let url = "http://monyucab.somee.com/api/Usuario/infoPersona";

    let id = parseInt(localStorage.getItem('idUsuario'), 10);

    this.http.post(url, {'id' : id}).
    toPromise().then((data : any) =>{
    }
    )
    
    return this.http.post(url, {'id' : id});

  }

  consultarComercio(){
    let url = "http://monyucab.somee.com/api/Usuario/infoComercio";

    let id = parseInt(localStorage.getItem('idUsuario'), 10);


    this.http.post(url, {'id' : id}).
    toPromise().then((data : any) =>{
    }
    )
    
    return this.http.post(url, {'id' : id});

  }

  ajustarPersona(){

  }

  ajustarComercio(){

  }

  ajustarUsuario(){

  }
}
