import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MovieSelectionComponent } from './movie-selection/movie-selection.component';
import { AdminLoginComponent } from './admin-login/admin-login.component';
import { AdminOptionsComponent } from './admin-options/admin-options.component';
import { LocationSelectionComponent } from './location-selection/location-selection.component';
import { IncorporateLocationComponent } from './incorporate-location/incorporate-location.component';
import { IncorporateMovieComponent } from './incorporate-movie/incorporate-movie.component';
import { IncorporateProyectionComponent } from './incorporate-proyection/incorporate-proyection.component';
import { IncorporateScreenComponent } from './incorporate-screen/incorporate-screen.component';
import { ProyectionSelectionComponent } from './proyection-selection/proyection-selection.component';
import { SeatSelectionComponent } from './seat-selection/seat-selection.component';

//In charge of administrate the url of the web
const routes: Routes = [
  //Path for the main page and his redirector
  {
    path: 'location-selection',
    component: LocationSelectionComponent
  },
  {
    path: '',
    redirectTo:'/location-selection',
    pathMatch: 'full'
  },

  //Path for admin login
  {
    path: 'admin-login',
    component: AdminLoginComponent
  },

  //Path for admin options
  {
    path: 'admin-options',
    component: AdminOptionsComponent
  },

  //Path for incorporate location
  {
    path: 'incorporate-location',
    component: IncorporateLocationComponent
  },

  //Path for incorporate movie
  {
    path: 'incorporate-movie',
    component: IncorporateMovieComponent
  },

  //Path for incorporate proyection
  {
    path: 'incorporate-proyection',
    component: IncorporateProyectionComponent
  },

  //Path for incorporate screen
  {
    path: 'incorporate-screen',
    component: IncorporateScreenComponent
  },

  //Path for movie selection
  {
    path: 'movie-selection',
    component: MovieSelectionComponent
  },

  //Path for proyection selection
  {
    path: 'proyection-selection',
    component: ProyectionSelectionComponent
  },

  //Path for seat selection
  {
    path: 'seat-selection',
    component: SeatSelectionComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
