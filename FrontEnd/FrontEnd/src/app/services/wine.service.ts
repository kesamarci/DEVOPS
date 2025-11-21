import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Wine } from '../models/wine';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class WineService {
 //private apiUrls = 'https://api.kesaszervere.ooguy.com/api/wine'; // módosítsd a saját backend portodra

  constructor(private http: HttpClient) { }

  getAll(): Observable<Wine[]> {
    return this.http.get<Wine[]>(environment.backendUrl + '/api/wine');
  }


  create(wine: Wine): Observable<Wine> {
    return this.http.post<Wine>(environment.backendUrl + '/api/wine', wine);
  }

  delete(id: string): Observable<void> {
    return this.http.delete<void>(`${environment.backendUrl + '/api/wine'}/${id}`);
  }
}

