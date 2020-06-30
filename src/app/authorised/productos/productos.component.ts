import { AgregarTarjetaService } from './../agregar-tarjeta/services/agregar-tarjeta.service';
import { AgregarCuentaService } from './../agregar-cuenta/services/agregar-cuenta.service';
import { ProductosService } from './services/productos.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.css']
})
export class ProductosComponent implements OnInit {

  tarjetas : any;
  cuentas : any;
  tipo : string;
  banco : string;

  constructor(public s_producto : ProductosService, public s_cuenta : AgregarCuentaService, public s_tarjeta : AgregarTarjetaService) { }

  ngOnInit(): void {
    this.consultarCuenta();
    this.consultarTarjeta();
  }

  consultarCuenta(){
    this.s_producto.consultarCuenta().subscribe((data : any )=>{
      this.cuentas = data;
    });;
  }

  
  consultarTarjeta(){
    this.s_producto.consultarTarjeta().subscribe(data =>{
      this.tarjetas = data;
      this.obtenerTipo();
      this.obtenerBanco();
    });
  }

  obtenerTipo(){
    if (this.tarjetas.idtipotarjeta == 1){
      this.tipo = 'Debito';
    }
    else{
      this.tipo = 'Corriente';
    }
  }

  agregarCuenta(){
    this.s_cuenta.show = true;
    this.s_producto.show = false;
  }

  agregarTarjeta(){
    this.s_tarjeta.show = true;
    this.s_producto.show = false;
  }

  ocultarProductos(){
    this.s_cuenta.show = false;
    this.s_tarjeta.show = false;
  }

  obtenerBanco(){
    if(this.tarjetas.idbanco == 1){
      this.banco = 'Mercantil';
    }
    else if(this.tarjetas.idbanco == 2) {
      this.banco = 'BOD'
    }
    else if( this.tarjetas.idbanco == 3) {
      this.banco ='Banco de Venezuela'
    }
    else if(this.tarjetas.idbanco == 4) {
      this.banco ='Bancaribe'
      
    }
     else if(this.tarjetas.idbanco == 5) {
      this.banco = 'Banco Plaza'
    }
    else if(this.tarjetas.idbanco == 6) {
      this.banco = 'Banco Bicentenario'
    }
  }
}
