import { Injectable, NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

@NgModule({
  providers: [APIService],
})

export class APIService {

  private urlApiTipoPlatos = 'https://localhost:7247/tiposplatos';
  private urlApiMenu = 'https://localhost:7247/menu';
 

  constructor(private http: HttpClient) { }

  getDataTipoPlatos(): Observable<any> {
    return this.http.get<any>(this.urlApiTipoPlatos)
  }

  postTipoPlatos(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiTipoPlatos, data);
  }

  getMenu(): Observable<any> {
    return this.http.get<any>(this.urlApiMenu)
  }

  postMenu(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiMenu, data);
  }

  
}
