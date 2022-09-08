import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IniciarsesionComponent } from './pages/iniciarsesion/iniciarsesion.component';
import { QuienessomosComponent } from './pages/quienessomos/quienessomos.component';
import { RegistroComponent } from './pages/registro/registro.component';
import { ServiciosComponent } from './pages/servicios/servicios.component';

const routes: Routes = [
  {path:'servicios',component:ServiciosComponent},
  {path:'quienessomos',component: QuienessomosComponent},
  {path:'registro',component: RegistroComponent},
  {path:'iniciarsesion',component:IniciarsesionComponent},
  {path: '', redirectTo: '/home', pathMatch: 'full'}, //redireccionamiento por defecto

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
