
import { Component, OnInit } from '@angular/core';

import { Usuario } from './../../models/usuario.model';
import { Persona } from './../../models/persona.model';
import { Comercio } from './../../models/comercio.model';

import { PerfilService } from './services/perfil.service';
@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.css']
})
export class PerfilComponent implements OnInit {

  infoPersona : Persona ={
    estadoCivil : 0,
    nombre : '',
    apellido : '',
    fechaNacimiento : ''
  };

  infoComercio : Comercio ={
    razonSocial : '',
    nombreRepresentante : '',
    apellidoRepresentante : ''
  };

  infoUsuario : Usuario = {
    idUsuario : 0,
    idTipoUsuario : 0,
    idTipoIdentificacion : 0,
    usuario : '',
    fechaRegistro : '',
    nroIdentificacion : 0,
    email : '',
    telefono : '',
    direccion : '',
    estatus : 0
  };
  estado : number;
  estadoCivil : number;
  tipoIdentificacion : number;
  tipoId : number;
  isDisabled : boolean = true;

  constructor(public s_perfil : PerfilService) { }

  ngOnInit(): void {
    this.consultar();
  }

  consultar(){
    this.consutarUsuario();
    if (parseInt(localStorage.getItem('idTipoUsuario'), 10) == 1){
      this.consutarPersona();
    }
    else if (parseInt(localStorage.getItem('idTipoUsuario'), 10) == 2){
      this.consultarComercio();
    }
  }
  consutarPersona(){
    this.s_perfil.consultarPersona().subscribe((data : any) => {
      this.infoPersona.estadoCivil = data.idestadocivil;
      this.infoPersona.nombre = data.nombre;
      this.infoPersona.apellido = data.apellido;
      this.infoPersona.fechaNacimiento = data.fecha_nacimiento;
    }
    );
    this.infoComercio = null;
  }

  consultarComercio(){
    this.s_perfil.consultarComercio().subscribe((data : any) =>{
      this.infoComercio.razonSocial = data.razon_social;
      this.infoComercio.nombreRepresentante = data.nombre_representante;
      this.infoComercio.apellidoRepresentante = data.apellido_representante;

    });

    this.infoPersona = null;

  }

  consutarUsuario(){
    this.s_perfil.consultarUSuario().subscribe((data : any) =>{
      this.infoUsuario.idUsuario = data.idusuario;
      this.infoUsuario.idTipoUsuario = data.idtipousuario;
      this.infoUsuario.idTipoIdentificacion = data.idtipoidentificacion;
      this.infoUsuario.usuario = data.usuario;
      this.infoUsuario.fechaRegistro = data.fecha_registro;
      this.infoUsuario.nroIdentificacion = data.nro_identificacion;
      this.infoUsuario.email = data.email;
      this.infoUsuario.telefono = data.telefono;
      this.infoUsuario.direccion = data.direccion;
      this.infoUsuario.estatus = data.estatus;
    });
  }

  editar(){
    this.isDisabled = false;
  }

  cancelar(){
    this.isDisabled = true;
  }
}
