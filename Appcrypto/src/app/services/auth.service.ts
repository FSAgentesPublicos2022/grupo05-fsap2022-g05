import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { map, take } from 'rxjs/operators';
import { Usuario } from './usuario.service';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  url = 'https://localhost:44380/api/CLIENTES';
  //"https://reqres.in/api/users/1";

  loggedIn = new BehaviorSubject<boolean>(false);
  currentUserSubject: BehaviorSubject<Usuario>;
  currentUser: Observable<Usuario>;

  constructor(private http: HttpClient) {
    console.log('Servicio de Autenticación está corriendo');
    this.currentUserSubject = new BehaviorSubject<Usuario>(
      JSON.parse(localStorage.getItem('currentUser') || '{}')
    );
    this.currentUser = this.currentUserSubject.asObservable();
  }
  login(usuario: Usuario): Observable<any> {
    return this.http.get<any>(this.url).pipe(
      take(1),
      map((data:any[]) => {
        console.log(data)
        console.log(usuario.email)
        console.log(usuario)
        console.log(usuario.password)
        const logIn = data.some(user=>user.Email===usuario.email && user.Password===usuario.password)
        localStorage.setItem('currentUser', JSON.stringify(data));
       // this.currentUserSubject.next(data);
        this.loggedIn.next(true);
        console.log(logIn)
        return logIn;
      })
    );
  }
  logout(): void {
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
