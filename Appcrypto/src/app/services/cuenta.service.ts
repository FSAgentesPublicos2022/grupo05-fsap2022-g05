import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CuentaService {

  constructor() { }
  ObtenerUltimosMovimientos()
{
return [{operacion:"Extracción",monto:1500}, {operacion:"Depósito", monto:1520}];
}
}
