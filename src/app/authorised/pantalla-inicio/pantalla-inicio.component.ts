import { Component, OnInit } from '@angular/core';

import { InicioService } from './services/inicio.service';

@Component({
  selector: 'app-pantalla-inicio',
  templateUrl: './pantalla-inicio.component.html',
  styleUrls: ['./pantalla-inicio.component.css']
})
export class PantallaInicioComponent implements OnInit {

  constructor(public s_inicio : InicioService) { }

  ngOnInit(): void {
  }

}
