import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.css']
})
export class AdminLoginComponent implements OnInit {
  
  validated = false;

  administrador = {
    user : '',
    password : ''
  };  


  Validar(){
    if(this.administrador.password == 'user' && this.administrador.user == 'user'){
      console.log(this.administrador)
      this.validated = true;
    }
  }

  constructor() { }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
}
