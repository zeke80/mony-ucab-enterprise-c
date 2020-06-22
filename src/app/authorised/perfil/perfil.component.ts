import { PerfilService } from './services/perfil.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.css']
})
export class PerfilComponent implements OnInit {

  constructor(public s_perfil : PerfilService) { }

  ngOnInit(): void {
  }

}
