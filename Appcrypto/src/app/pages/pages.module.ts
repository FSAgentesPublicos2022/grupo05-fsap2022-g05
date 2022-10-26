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
import { RouterModule } from '@angular/router'
import { Pagina404Component } from './pagina404/pagina404.component';
import { ReactiveFormsModule } from '@angular/forms';
import { IngresoComponent } from './operaciones/ingreso/ingreso.component';
import { CompraVentaComponent } from './operaciones/compra-venta/compra-venta.component';
import { TransferenciaComponent } from './operaciones/transferencia/transferencia.component';
import { CotizacionComponent } from './cotizacion/cotizacion.component';


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
    TransaccionesComponent,
    Pagina404Component,
    IngresoComponent,
    CompraVentaComponent,
    TransferenciaComponent,
    CotizacionComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    ReactiveFormsModule
  ],

  exports:[
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
})

export class PagesModule { }
