import { Component, OnInit } from '@angular/core';
import { CuentaService } from './cuenta/cuenta.service';
import { Cuenta } from '../models/cuenta.model';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page implements OnInit {

  cuentas = []

  constructor(
    public _cuentaServices: CuentaService
  ) {}

  ngOnInit(){
    this.cuentas = this._cuentaServices.getCuentas();
  }

}
