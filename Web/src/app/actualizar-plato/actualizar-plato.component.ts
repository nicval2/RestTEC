import { Component } from '@angular/core';

@Component({
  selector: 'app-actualizar-plato',
  templateUrl: './actualizar-plato.component.html',
  styleUrls: ['./actualizar-plato.component.css']
})
export class ActualizarPlatoComponent {
  locations : string[] =
  [
    'San José','Alajuela', 'Heredia','Cartago','Guanacaste', 'Limón'
  ];

}
