import { Component } from '@angular/core';

@Component({
  selector: 'app-seat-selection',
  templateUrl: './seat-selection.component.html',
  styleUrls: ['./seat-selection.component.css']
})
export class SeatSelectionComponent {
  rows: number = 7;
  columns: number = 7;
  rowsArray = new Array(this.rows).fill(null).map((_, i) => i + 1);
  columnsArray = new Array(this.columns).fill(null).map((_, i) => i + 1);
}
