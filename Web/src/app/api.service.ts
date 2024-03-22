import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class APIService {

  private urlApiLocation = 'https://localhost:7247/location';
  private urlApiScreens = 'https://localhost:7247/location';
  private urlApiMovie = 'https://localhost:7247/location';
  private urlApiDirector = 'https://localhost:7247/location';
  private urlApiActors = 'https://localhost:7247/location';
  private urlApiProyection = 'https://localhost:7247/location';
  private urlApiClassification = 'https://localhost:7247/location';


  constructor(private http: HttpClient) { }

  getDataLocation(): Observable<any> {
    return this.http.get<any>(this.urlApiLocation)
  }

  postDataLocation(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiLocation, data);
  }

  getDataScreens(): Observable<any> {
    return this.http.get<any>(this.urlApiScreens)
  }

  postDataScreens(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiScreens, data);
  }

  getDataMovie(): Observable<any> {
    return this.http.get<any>(this.urlApiMovie)
  }

  postDataMovie(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiMovie, data);
  }

  getDataDirectors(): Observable<any> {
    return this.http.get<any>(this.urlApiDirector)
  }

  postDataDirectors(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiDirector, data);
  }

  getDataActors(): Observable<any> {
    return this.http.get<any>(this.urlApiActors)
  }

  postDataActors(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiActors, data);
  }

  getDataProyection(): Observable<any> {
    return this.http.get<any>(this.urlApiProyection)
  }

  postDataProyection(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiProyection, data);
  }

  getDataClassification(): Observable<any> {
    return this.http.get<any>(this.urlApiClassification)
  }

  postDataClassification(data: any): Observable<any> {
    return this.http.post<any>(this.urlApiClassification, data);
  }
}
