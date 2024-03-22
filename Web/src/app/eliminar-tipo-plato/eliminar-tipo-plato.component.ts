import { Component } from '@angular/core';

@Component({
  selector: 'app-eliminar-tipo-plato',
  templateUrl: './eliminar-tipo-plato.component.html',
  styleUrls: ['./eliminar-tipo-plato.component.css']
})
export class EliminarTipoPlatoComponent {
  locations : string[] =
  [
    'San José','Alajuela', 'Heredia','Cartago','Guanacaste', 'Limón'
  ];

}
