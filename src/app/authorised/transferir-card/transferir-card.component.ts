import { TransferirService } from './services/transferir.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-transferir-card',
  templateUrl: './transferir-card.component.html',
  styleUrls: ['./transferir-card.component.css']
})
export class TransferirCardComponent implements OnInit {

  constructor(public s_transferir : TransferirService) { }

  ngOnInit(): void {
  }

}
