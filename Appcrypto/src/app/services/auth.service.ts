import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Usuario } from './usuario.service';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'

})

export class AuthService {
  url="https://localhost:44392";
  //"https://reqres.in/api/users/1";

loggedIn= new BehaviorSubject<boolean>(false);
currentUserSubject: BehaviorSubject<Usuario>;
currentUser: Observable<Usuario>;

  constructor(private http:HttpClient) {
      console.log("Servicio de Autenticación está corriendo");
      this.currentUserSubject = new
      BehaviorSubject<Usuario>(JSON.parse(localStorage.getItem('currentUser') || '{}'));
      this.currentUser = this.currentUserSubject.asObservable();
      }
      login(usuario: Usuario): Observable<any> {
        return this.http.post<any>(this.url, usuario)
        .pipe(map(data => {
        localStorage.setItem('currentUser', JSON.stringify(data ));
        this.currentUserSubject.next(data);
this.loggedIn.next(true);
return data;
}));
}
logout(): void{
  localStorage.removeItem('currentUser');
  this.loggedIn.next(false);
  }
  get usuarioAutenticado(): Usuario {
    return this.currentUserSubject.value;
    }
    get estaAutenticado(): Observable<boolean> {
    return this.loggedIn.asObservable();
    }
}
