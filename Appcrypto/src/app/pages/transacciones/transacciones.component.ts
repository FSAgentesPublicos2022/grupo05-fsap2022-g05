import { Component, OnInit } from '@angular/core';
import { CuentaService } from 'src/app/services/cuenta.service';

@Component({
  selector: 'app-transacciones',
  templateUrl: './transacciones.component.html',
  styleUrls: ['./transacciones.component.css']
})
export class TransaccionesComponent implements OnInit {

  hoy= new Date();
  mostrarMovimientos: boolean=true;
  movimientos=[{operacion:"Extracción",monto:1500}, {operacion:"Depósito", monto:1520}];

  constructor( cuenta:CuentaService) {
    this.movimientos=cuenta.ObtenerUltimosMovimientos();
  }

  ngOnInit(): void {
  }

}
