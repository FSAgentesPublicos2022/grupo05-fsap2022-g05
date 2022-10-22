import { Injectable } from '@angular/core';
import {HttpClient } from'@angular/common/http';
import { Observable } from 'rxjs';

export class Usuario
{
nombre:string="";
apellido:string="";
dni:string="";
password:string="";
email:string="";
id:number=0;
}

@Injectable({
  providedIn: 'root'
})

export class UsuarioService {

  url= "https://localhost:44380/api/CLIENTES";
 //url= "https://reqres.in/api/users/1"

  constructor(private http:HttpClient)
  {console.log("Servicio Usuarios está corriendo");
 }
 onCrearUsuario(usuario:Usuario):Observable<Usuario>{
  return this.http.post<Usuario>(this.url, usuario);
  }
}
