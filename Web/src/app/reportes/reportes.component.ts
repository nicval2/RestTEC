import { Component } from '@angular/core';

@Component({
  selector: 'app-reportes',
  templateUrl: './reportes.component.html',
  styleUrls: ['./reportes.component.css']
})
export class ReportesComponent {
  locations : string[] =
  [
    'Top 10 platos más vendidos', 'Top 10 platos que más ganancias generan', 
    'Top 10 platos con mejor feedback'
  ];

}
