import { MovimientosService } from './services/movimientos.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tabla-movimientos',
  templateUrl: './tabla-movimientos.component.html',
  styleUrls: ['./tabla-movimientos.component.css']
})
export class TablaMovimientosComponent implements OnInit {

  movimientosCuenta : any;
  movimientosTarjeta : any;
  movimientosMonedero : any;
  saldo : any;

  constructor(public s_movimientos : MovimientosService) { }

  ngOnInit(): void {
    this.s_movimientos.consultarCuentas().subscribe(data =>{
      this.movimientosCuenta = data;
    });

    this.s_movimientos.consultarTarjeta().subscribe(data =>{
      this.movimientosTarjeta = data;
    });

    this.s_movimientos.consutarMonedero() .subscribe(data =>{
      this.movimientosMonedero = data;
    });

    this.s_movimientos.consultarSaldo().subscribe(data => {
      this.saldo = data;
    });
    
  }

  consultarSoloTarjeta(){

    this.s_movimientos.consultarTarjeta().subscribe(data =>{
      this.movimientosTarjeta = data;
    });

    this.movimientosCuenta = null;

    this.movimientosMonedero = null;
  }

  consultarSoloMonedero(){

    this.s_movimientos.consutarMonedero() .subscribe(data =>{
      this.movimientosMonedero = data;
    });

    this.movimientosCuenta = null;
    
    this.movimientosTarjeta = null;
  }


  consultarSoloCuenta(){

    this.s_movimientos.consultarCuentas().subscribe(data =>{
      this.movimientosCuenta = data;
    });
    
    this.movimientosCuenta = null;

    this.movimientosTarjeta = null;
  }

}
