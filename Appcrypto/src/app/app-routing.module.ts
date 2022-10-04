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
import { Pagina404Component } from './pages/pagina404/pagina404.component';

const routes: Routes = [
  {path:'servicios',component:ServiciosComponent},
  {path:'quienessomos',component: QuienessomosComponent},
  {path:'quienessomos/:id',component:IntegranteComponent},
  {path:'registro',component: RegistroComponent},
  {path:'iniciarsesion',component:IniciarsesionComponent},
  {path:'home', component: HomeComponent,
children:[
{path:'operaciones', component: OperacionesComponent},
{path:'transacciones', component: TransaccionesComponent},
{path:'criptomoneda', component: CriptomonedaComponent},

{path: '**', component: Pagina404Component}
]}
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
