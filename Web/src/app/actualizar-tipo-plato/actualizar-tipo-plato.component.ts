import { Component } from '@angular/core';

@Component({
  selector: 'app-actualizar-tipo-plato',
  templateUrl: './actualizar-tipo-plato.component.html',
  styleUrls: ['./actualizar-tipo-plato.component.css']
})
export class ActualizarTipoPlatoComponent {
  locations : string[] =
  [
    'San José','Alajuela', 'Heredia','Cartago','Guanacaste', 'Limón'
  ];

}
