import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup,Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { UsuarioService,Usuario } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-iniciarsesion',
  templateUrl: './iniciarsesion.component.html',
  styleUrls: ['./iniciarsesion.component.css']
})
export class IniciarsesionComponent implements OnInit {
  usuario: Usuario = new Usuario();
  error:Error | undefined;                 // VER SI ESTA OK

  form: FormGroup;

  constructor(private formBuilder : FormBuilder,UsuarioServicio:UsuarioService,
    private authService: AuthService,
    private router: Router){
   this.form= this.formBuilder.group(
    {
      password: ['',[Validators.required,Validators.minLength(8)]],
      email:['',[Validators.required, Validators.email]]
    })
   }
   get Password()
   {
     return this.form.get("password");
   }
   get Mail()
   {
    return this.form.get("mail");
   }
   get PasswordValid()
   {
     return this.Password?.touched && !this.Password?.valid;
   }
   get MailValid()
   {
     return this.Mail?.touched && !this.Mail?.valid;
   }

  ngOnInit(): void {
  }
  onEnviar(event: Event): void {
    event.preventDefault();
    this.authService.login({...this.form.value})
.subscribe(
data => { if (data) {

  this.router.navigate(['/home']);
}else{alert("la contraseña o usuario son incorrectos")}
},

error => {
  this['error'] = error;
 }
);
}
}





