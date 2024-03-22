import { Component } from '@angular/core';

@Component({
  selector: 'gestion-pedido',
  templateUrl: './gestion-pedido.component.html',
  styleUrls: ['./gestion-pedido.component.css']
})
export class GestionPedidoComponent {
  rows: number = 1;
  columns: number = 2;
  rowsArray = new Array(this.rows).fill(null).map((_, i) => i + 1);
  columnsArray = new Array(this.columns).fill(null).map((_, i) => i + 1);
}
