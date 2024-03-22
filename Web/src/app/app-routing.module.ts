import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminLoginComponent } from './admin-login/admin-login.component';
import { AdminOptionsComponent } from './admin-options/admin-options.component';
import { ActualizarPlatoComponent } from './actualizar-plato/actualizar-plato.component';
import { GestionTiposComponent } from './gestion-tipos/gestion-tipos.component';
import { TomarPedidoComponent } from './tomar-pedido/tomar-pedido.component';
import { CrearPlatoComponent } from './crear-plato/crear-plato.component';
import { EliminarPlatoComponent } from './eliminar-plato/eliminar-plato.component';
import { ChefOptionsComponent } from './chef-options/chef-options.component';
import { GestionMenuComponent } from './gestion-menu/gestion-menu.component';
import { ReportesComponent } from './reportes/reportes.component';
import { CrearTipoPlatoComponent } from './crear-tipo-plato/crear-tipo-plato.component';
import { ActualizarTipoPlatoComponent } from './actualizar-tipo-plato/actualizar-tipo-plato.component';
import { EliminarTipoPlatoComponent } from './eliminar-tipo-plato/eliminar-tipo-plato.component';
import { GestionPedidoComponent } from './gestion-pedido/gestion-pedido.component';
import { ReasignarPedidoComponent } from './reasignar-pedido/reasignar-pedido.component';

//In charge of administrate the url of the web
const routes: Routes = [
  //Path for the main page and his redirector
  {
    path: 'admin-login',
    component: AdminLoginComponent
  },
  {
    path: '',
    redirectTo:'/admin-login',
    pathMatch: 'full'
    
  },

  {
    path: 'actualizar-plato',
    component: ActualizarPlatoComponent
  },

  //Path for admin options
  {
    path: 'admin-options',
    component: AdminOptionsComponent
  },
  {
    path: 'chef-options',
    component : ChefOptionsComponent
  },
  {
    path: 'gestion-tipos',
    component: GestionTiposComponent
  },

  {
    path: 'tomar-pedido',
    component: TomarPedidoComponent
  },
  {
    path:'crear-plato',
    component: CrearPlatoComponent
  },
  {
    path: 'eliminar-plato',
    component: EliminarPlatoComponent
  },
  {
    path: 'gestion-menu',
    component: GestionMenuComponent
  },
  {
    path: 'reportes',
    component: ReportesComponent
  },
  {
    path: 'crear-tipo-plato',
    component: CrearTipoPlatoComponent
  },
  {
    path: 'actualizar-tipo-plato',
    component: ActualizarTipoPlatoComponent
  },
  {
    path: 'eliminar-tipo-plato',
    component: EliminarTipoPlatoComponent
  },
  {
    path: 'gestion-pedido',
    component: GestionPedidoComponent
  },
  {
    path: 'reasignar-pedido',
    component: ReasignarPedidoComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
