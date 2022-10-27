import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutModule } from './layout/layout.module';
import { PagesModule } from './pages/pages.module';
import { ReactiveFormsModule } from '@angular/forms';
import {HttpClientModule } from'@angular/common/http';
import { UsuarioService } from './services/usuario.service';
import { CargarScriptsService } from './services/cargar-scripts.service';

@NgModule({
  declarations: [
    AppComponent
  ],

  imports: [
    BrowserModule,
    LayoutModule,
    PagesModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,

  ],
  providers: [UsuarioService, CargarScriptsService],   //UsuarioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
