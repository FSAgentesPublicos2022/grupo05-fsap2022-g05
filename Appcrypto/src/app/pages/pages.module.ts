import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ServiciosComponent } from './servicios/servicios.component';
import { QuienessomosComponent } from './quienessomos/quienessomos.component';
import { RegistroComponent } from './registro/registro.component';
import { IniciarsesionComponent } from './iniciarsesion/iniciarsesion.component';
import { IntegranteComponent } from './integrante/integrante.component';
import { HomeComponent } from './home/home.component';
import { OperacionesComponent } from './operaciones/operaciones.component';
import { CriptomonedaComponent } from './criptomoneda/criptomoneda.component';
import { TransaccionesComponent } from './transacciones/transacciones.component';



@NgModule({
  declarations: [
    ServiciosComponent,
    QuienessomosComponent,
    RegistroComponent,
    IniciarsesionComponent,
    IntegranteComponent,
    HomeComponent,
    OperacionesComponent,
    CriptomonedaComponent,
    TransaccionesComponent
  ],
  imports: [
    CommonModule
  ]
})
export class PagesModule { }
