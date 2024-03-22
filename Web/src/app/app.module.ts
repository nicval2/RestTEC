import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';

import { HTTP_INTERCEPTORS } from '@angular/common/http';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AdminLoginComponent } from './admin-login/admin-login.component';
import { AdminOptionsComponent } from './admin-options/admin-options.component';
import { TomarPedidoComponent } from './tomar-pedido/tomar-pedido.component';
import { ActualizarPlatoComponent } from './actualizar-plato/actualizar-plato.component';
import { GestionTiposComponent } from './gestion-tipos/gestion-tipos.component';
import { CrearPlatoComponent } from './crear-plato/crear-plato.component';
import { EliminarPlatoComponent } from './eliminar-plato/eliminar-plato.component';
import { ChefOptionsComponent } from './chef-options/chef-options.component';
import { GestionMenuComponent } from './gestion-menu/gestion-menu.component';

import {FormsModule} from '@angular/forms';

import { APIService } from './api.service';
import { HttpClientModule } from '@angular/common/http'
import { MyHttpInterceptor } from './http-interceptor.service';
import { ReportesComponent } from './reportes/reportes.component';
import { CrearTipoPlatoComponent } from './crear-tipo-plato/crear-tipo-plato.component';
import { ActualizarTipoPlatoComponent } from './actualizar-tipo-plato/actualizar-tipo-plato.component';
import { EliminarTipoPlatoComponent } from './eliminar-tipo-plato/eliminar-tipo-plato.component';

@NgModule({
  declarations: [
    AppComponent,
    AdminLoginComponent,
    AdminOptionsComponent,
    TomarPedidoComponent,
    ActualizarPlatoComponent,
    GestionTiposComponent,
    CrearPlatoComponent,
    EliminarPlatoComponent,
    ChefOptionsComponent,
    GestionMenuComponent,
    ReportesComponent,
    CrearTipoPlatoComponent,
    ActualizarTipoPlatoComponent,
    EliminarTipoPlatoComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [ { provide: HTTP_INTERCEPTORS, useClass: MyHttpInterceptor, multi: true }],
  bootstrap: [AppComponent]
})
export class AppModule { }
