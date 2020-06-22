import { ConfiguracionesService } from './services/configuraciones.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-configuraciones',
  templateUrl: './configuraciones.component.html',
  styleUrls: ['./configuraciones.component.css']
})
export class ConfiguracionesComponent implements OnInit {

  constructor(public s_configuraciones : ConfiguracionesService) { }

  ngOnInit(): void {
  }

}
