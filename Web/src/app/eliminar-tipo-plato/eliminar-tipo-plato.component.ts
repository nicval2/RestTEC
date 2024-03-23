import { Component } from '@angular/core';

@Component({
  selector: 'app-eliminar-tipo-plato',
  templateUrl: './eliminar-tipo-plato.component.html',
  styleUrls: ['./eliminar-tipo-plato.component.css']
})
export class EliminarTipoPlatoComponent {
  tipoplato : string[] =
  [
    'Postres', 'Platos fuertes', 'Entradas'
  ];

}
