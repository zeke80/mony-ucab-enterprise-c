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

  constructor(public s_producto : ProductosService) { }

  ngOnInit(): void {
    this.consultarCuenta();
    this.consultarTarjeta();
  }

  consultarCuenta(){
    this.s_producto.consultarCuenta().subscribe(data =>{
      this.cuentas = data;
    });;
  }

  
  consultarTarjeta(){
    this.s_producto.consultarTarjeta().subscribe(data =>{
      this.tarjetas = data;
    });
  }
}
