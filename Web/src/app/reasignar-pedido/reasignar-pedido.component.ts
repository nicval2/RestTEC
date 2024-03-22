import { Component } from '@angular/core';

@Component({
  selector: 'reasignar-pedido',
  templateUrl: './reasignar-pedido.component.html',
  styleUrls: ['./reasignar-pedido.component.css']
})
export class ReasignarPedidoComponent {
  rows: number = 1;
  columns: number = 2;
  rowsArray = new Array(this.rows).fill(null).map((_, i) => i + 1);
  columnsArray = new Array(this.columns).fill(null).map((_, i) => i + 1);
}
