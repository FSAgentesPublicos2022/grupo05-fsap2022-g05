import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IniciarsesionComponent } from './pages/iniciarsesion/iniciarsesion.component';
import { QuienessomosComponent } from './pages/quienessomos/quienessomos.component';
import { RegistroComponent } from './pages/registro/registro.component';
import { ServiciosComponent } from './pages/servicios/servicios.component';
import { IntegranteComponent } from './pages/integrante/integrante.component';
import { HomeComponent } from './pages/home/home.component';
import { OperacionesComponent } from './pages/operaciones/operaciones.component';
import { TransaccionesComponent } from './pages/transacciones/transacciones.component';
import { CriptomonedaComponent } from './pages/criptomoneda/criptomoneda.component';
import { IngresoComponent } from './pages/operaciones/ingreso/ingreso.component';
import { CompraVentaComponent } from './pages/operaciones/compra-venta/compra-venta.component';
import { TransferenciaComponent } from './pages/operaciones/transferencia/transferencia.component';
import { CotizacionComponent } from './pages/cotizacion/cotizacion.component';

const routes: Routes = [
  { path: 'servicios', component: ServiciosComponent },
  { path: 'quienessomos', component: QuienessomosComponent },
  { path: 'quienessomos/:id', component: IntegranteComponent },
  { path: 'registro', component: RegistroComponent },
  { path: 'iniciarsesion', component: IniciarsesionComponent },
  { path: 'criptomoneda', component: CriptomonedaComponent },
  {path:'cotizacion',component:CotizacionComponent},
  { path: 'operaciones', component: OperacionesComponent }, //Agregar rutas hijas Ingreso, ventay compra , trsnferencia.

  {
    path: 'home',
    component: HomeComponent,
    children: [
      { path: 'transacciones', component: TransaccionesComponent },
      { path: 'operaciones',component: OperacionesComponent },
      { path: 'ingreso', component: IngresoComponent },
      { path: 'compra-venta', component: CompraVentaComponent },
      { path: 'transferencia', component: TransferenciaComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
