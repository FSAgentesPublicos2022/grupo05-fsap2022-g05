import { Injectable } from '@angular/core';
/*import { HttpClient } from '@angular/common/http';*/

@Injectable({
  providedIn: 'root'
})
export class CuentaService {
 /* constructor(private htt:HttpClient){

  }*/

  constructor() { }
  ObtenerUltimosMovimientos()
{
return [{operacion:"Extracción",monto:1500}, {operacion:"Depósito", monto:1520}];
}
}
