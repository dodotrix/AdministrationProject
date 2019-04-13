import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IPacijent } from './pacijent';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class PacijentService {
  private apiURL: string = 'https://localhost:44395/api/';


  constructor(private http: HttpClient) { }

  public getPacijenti(): Observable<IPacijent[]>{
    return this.http.get<IPacijent[]>(`${this.apiURL}pacijent`);
  }

}
