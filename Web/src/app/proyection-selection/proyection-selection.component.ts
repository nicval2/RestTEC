import { Component } from '@angular/core';

@Component({
  selector: 'app-proyection-selection',
  templateUrl: './proyection-selection.component.html',
  styleUrls: ['./proyection-selection.component.css']
})
export class ProyectionSelectionComponent {

  schedules : string [] = [
    '6:50 p.m.',
    '7:00 p.m.',
    '9:00 p.m.',
    '9:30 p.m.',
    '10:00 p.m.'
  ];

}
