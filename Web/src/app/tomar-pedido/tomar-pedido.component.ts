import { Component } from '@angular/core';

@Component({
  selector: 'tomar-pedido',
  templateUrl: './tomar-pedido.component.html',
  styleUrls: ['./tomar-pedido.component.css']
})
export class TomarPedidoComponent {
  rows: number = 2;
  columns: number = 3;
  rowsArray = new Array(this.rows).fill(null).map((_, i) => i + 1);
  columnsArray = new Array(this.columns).fill(null).map((_, i) => i + 1);
}
