import { Component } from '@angular/core';

@Component({
  selector: 'app-eliminar-plato',
  templateUrl: './eliminar-plato.component.html',
  styleUrls: ['./eliminar-plato.component.css']
})
export class EliminarPlatoComponent {
  locations : string[] =
  [
    'San José','Alajuela', 'Heredia','Cartago','Guanacaste', 'Limón'
  ];

}
