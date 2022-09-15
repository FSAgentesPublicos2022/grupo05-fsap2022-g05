import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ServiciosComponent } from './servicios/servicios.component';
import { QuienessomosComponent } from './quienessomos/quienessomos.component';
import { RegistroComponent } from './registro/registro.component';
import { IniciarsesionComponent } from './iniciarsesion/iniciarsesion.component';



@NgModule({
  declarations: [
    ServiciosComponent,
    QuienessomosComponent,
    RegistroComponent,
    IniciarsesionComponent
  ],
  imports: [
    CommonModule
  ]
})
export class PagesModule { }
