import { Component, OnInit } from '@angular/core';
import { BloquearService } from './services/bloquear.service';

@Component({
  selector: 'app-bloquear',
  templateUrl: './bloquear.component.html',
  styleUrls: ['./bloquear.component.css']
})
export class BloquearComponent implements OnInit {

  constructor(public s_bloquear : BloquearService) { }

  ngOnInit(): void {
  }

}
