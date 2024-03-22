import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminLoginComponent } from './admin-login/admin-login.component';
import { AdminOptionsComponent } from './admin-options/admin-options.component';
import { ActualizarPlatoComponent } from './actualizar-plato/actualizar-plato.component';
import { GestionPlatosComponent } from './gestion-platos/gestion-platos.component';
import { TomarPedidoComponent } from './tomar-pedido/tomar-pedido.component';
import { CrearPlatoComponent } from './crear-plato/crear-plato.component';
import { EliminarPlatoComponent } from './eliminar-plato/eliminar-plato.component';
import { ChefOptionsComponent } from './chef-options/chef-options.component';
import { GestionMenuComponent } from './gestion-menu/gestion-menu.component';
import { ReportesComponent } from './reportes/reportes.component';

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
    path: 'gestion-platos',
    component: GestionPlatosComponent
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
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
