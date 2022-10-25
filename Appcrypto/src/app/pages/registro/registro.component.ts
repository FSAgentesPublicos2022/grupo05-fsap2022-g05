import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UsuarioService, Usuario } from 'src/app/services/usuario.service';
import { Router } from '@angular/router';
import { take } from 'rxjs';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css'],
})
export class RegistroComponent implements OnInit {
  form: FormGroup;
  usuario: Usuario = new Usuario();

  constructor(
    private formBuilder: FormBuilder,
    private usuarioService: UsuarioService,
    private router: Router
  ) {
    this.form = this.formBuilder.group({
      Nombre: ['', [Validators.required]],
      Apellido: ['', [Validators.required]],
      DNI: ['', [Validators.required]],
      Password: ['', [Validators.required]],
      password2: ['', [Validators.required]],
      Email: ['', [Validators.required, Validators.email]],
    });
  }

  ngOnInit(): void {}

  onEnviar(event: Event): void {
    event.preventDefault;
    if (this.form.valid) {
      console.log('Enviando al servidor...');
      console.log(this.form.value);
      this.usuarioService
        .onCrearUsuario({ ...this.form.value })
        .pipe(take(1))
        .subscribe((data:any) => {
          if (data.Id_Cliente > 0) {
            alert(
              'El registro ha sido creado satisfactoriamente. A continuación,por favor Inicie Sesión.'
            );
            this.router.navigate(['/iniciarsesion']);
          }
        });
    } else {
      this.form.markAllAsTouched();
    }
  }

  get password1() {
    return this.form.get('password1');
  }
  get password2() {
    return this.form.get('password2');
  }
  get email() {
    return this.form.get('email');
  }
  get Nombre() {
    return this.form.get('nombre');
  }
  get Apellido() {
    return this.form.get('apellido');
  }
  get Dni() {
    return this.form.get('dni');
  }
  get emailValid() {
    return this.email?.touched && !this.email?.valid;
  }
  get NombreValid() {
    return this.Nombre?.touched && !this.Nombre?.valid;
  }
  get ApellidoValid() {
    return this.Apellido?.touched && !this.Apellido?.valid;
  }
  get password1Valid() {
    return this.password1?.touched && !this.password1?.valid;
  }
  get password2Valid() {
    return this.password2?.touched && !this.password2?.valid;
  }
  get DniValid() {
    return this.Dni?.touched && !this.Dni?.valid;
  }
}
