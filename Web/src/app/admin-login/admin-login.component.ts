import { Component, OnInit } from '@angular/core';
import { ChefOptionsComponent } from '../chef-options/chef-options.component';
import { AdminOptionsComponent } from '../admin-options/admin-options.component';

@Component({
  selector: 'app-admin-login',
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin-login.component.css']
})
export class AdminLoginComponent implements OnInit {
  
  validated = false;
  validatedchef = false;

  administrador = {
    user : '',
    password : ''
  };  


  Validar(){
    if(this.administrador.password == 'user' && this.administrador.user == 'user'){
      console.log(this.administrador)
      this.validated = true;
      this.validatedchef = false;
    }
    if(this.administrador.password == '1234' && this.administrador.user == '1234'){
      console.log(this.administrador)
      this.validatedchef = true;
      this.validated = false;
    }
  }

  constructor() { }

  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
}
