import { Component } from '@angular/core';

@Component({
  selector: 'app-location-selection',
  templateUrl: './location-selection.component.html',
  styleUrls: ['./location-selection.component.css']
})
export class LocationSelectionComponent {
  locations : string[] =
  [
    'San José','Alajuela', 'Heredia','Cartago','Guanacaste', 'Limón'
  ];

}
