import { Component, OnInit } from '@angular/core';
import { APIService } from '../api.service';

@Component({
  selector: 'app-incorporate-location',
  templateUrl: './incorporate-location.component.html',
  styleUrls: ['./incorporate-location.component.css']
})
export class IncorporateLocationComponent {

  dataLocation:any;
  dataScreen:any; 

  
  dataL = {
    idLocation : 0,
    name: '',
    place : '',
    numScreens : 0
  };

  dataS = {
    idScreen : 0,
    name: '',
    row: 0,
    column: 0,
    capacity : 0,
    locationID : this.dataL
  }

  constructor(private apiService: APIService){ };

  PostL(){
    this.apiService.postDataLocation(this.dataL).subscribe(data => {
      console.log(this.dataL)
      //this.dataLocation = data;
    })
  }

  PostS(){
    this.apiService.postDataScreens(this.dataS).subscribe(data => {
      console.log(this.PostS)
      //this.dataScreen = data;
    })
  }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
}
