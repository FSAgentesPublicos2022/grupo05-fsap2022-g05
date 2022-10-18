import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from 'src/app/services/auth.service';
import { UsuarioService , Usuario  } from 'src/app/services/usuario.service';


@Component({
  selector: 'app-iniciarsesion',
  templateUrl: './iniciarsesion.component.html',
  styleUrls: ['./iniciarsesion.component.css']
})
export class IniciarsesionComponent implements OnInit {
  form: FormGroup;
  usuario: Usuario [];
  constructor(private formBuilder : FormBuilder,
    private authService: AuthService,
    private usuarioService:UsuarioService,
    private router: Router){
   this.form= this.formBuilder.group(
    {
      password: ['',[Validators.required,Validators.minLength(8)]],
      mail:['',[Validators.required, Validators.email]]
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
  onEnviar(event: Event, usuario:Usuario): void {
    event.preventDefault;
    this.authService.login(this.Usuario)
.subscribe(
data => {
console.log("DATA"+ JSON.stringify( data));
this.router.navigate(['/home/movimientos']);
},
error => {
this.error = error;
}
);
}
}





