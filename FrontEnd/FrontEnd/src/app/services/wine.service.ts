import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Wine } from '../models/wine';

@Injectable({
  providedIn: 'root'
})
export class WineService {
 private apiUrl = 'https://api.kesaszervere.ooguy.com/api/wine'; // módosítsd a saját backend portodra

  constructor(private http: HttpClient) { }

  getAll(): Observable<Wine[]> {
    return this.http.get<Wine[]>(this.apiUrl);
  }


  create(wine: Wine): Observable<Wine> {
    return this.http.post<Wine>(this.apiUrl, wine);
  }

  delete(id: string): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}

