import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-pago',
  templateUrl: './pago.page.html',
  styleUrls: ['./pago.page.scss'],
})
export class PagoPage implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  realizarSolicitud( f: NgForm) {
    console.log(f.value.userRecep);
  }

}
