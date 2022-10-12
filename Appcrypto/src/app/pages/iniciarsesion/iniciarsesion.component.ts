import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { FormBuilder, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-iniciarsesion',
  templateUrl: './iniciarsesion.component.html',
  styleUrls: ['./iniciarsesion.component.css']
})
export class IniciarsesionComponent implements OnInit {
  form: FormGroup;
  constructor(private formBuilder : FormBuilder) {
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
}





