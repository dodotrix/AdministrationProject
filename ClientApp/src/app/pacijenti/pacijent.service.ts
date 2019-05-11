import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { IPacijent } from './pacijent';
import { Observable, throwError } from "rxjs";
import { catchError, tap} from "rxjs/operators";

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
};

@Injectable({
  providedIn: 'root'
})
export class PacijentService {
  private apiURL: string = 'https://localhost:44395/api/pacijent';

  constructor(private http: HttpClient) { }

  public getPacijenti(): Observable<IPacijent[]>{
    return this.http.get<IPacijent[]>(`${this.apiURL}`);
  }

  public getPacijentById(id: number): Observable<IPacijent>{
    return this.http.get<IPacijent>(`${this.apiURL}/` + id).pipe(
      catchError(this.handleError)
    );
  }

  public addPacijent(pacijent: IPacijent): Observable<IPacijent> {
    return this.http.post<IPacijent>(`${this.apiURL}/addPacijent`, pacijent, httpOptions).pipe(
      catchError(this.handleError)
    );
  }

  public removePacijent(id: number): Observable<{}>{
      return this.http.delete(`${this.apiURL}/` + id, httpOptions).pipe(
        catchError(this.handleError)
      )
  }

  private handleError(err: HttpErrorResponse){
    let errorMessage = '';
    if(err.error instanceof ErrorEvent){
      errorMessage = `An error occured:  ${err.error.message}`;
    }  else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }

    console.error(errorMessage);
    return throwError(errorMessage);
  }

}
