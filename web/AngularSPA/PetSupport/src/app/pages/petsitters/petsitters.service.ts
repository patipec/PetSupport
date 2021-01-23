import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable, of, throwError} from 'rxjs';
import {catchError, map, tap} from 'rxjs/operators';
import {Petsitter, PetsitterCreate, PetsitterUpdate} from '../../common/models/petsitter';
import { FindPetsitterShortForm} from '../../common/models/forms';

const PETSITTER_URL = 'http://localhost:5001/api/Petsitters';


@Injectable({
  providedIn: 'root'
})
export class PetsittersService {

  constructor(private http: HttpClient) {}


  public getPetsitters(formData: FindPetsitterShortForm): Observable<Petsitter[]> {
    const params = this.getHttpParamsFromObject(formData);

    return this.http.get<Petsitter[]>(PETSITTER_URL, {params})
      .pipe(
        tap(data => console.log(data)),
        catchError(this.handleError)
      );
  }

  public getPetsitter(petsitterId: number): Observable<Petsitter> {
    return this.http.get<Petsitter>(`${PETSITTER_URL}/${petsitterId}`);
  }

  public createPetsitter(petsitter: PetsitterCreate): Observable<Petsitter> {
    return this.http.post<Petsitter>(PETSITTER_URL, petsitter);
  }

  public updatePetsitter(petsitter: PetsitterUpdate): Observable<Petsitter> {
    return this.http.put<Petsitter>(PETSITTER_URL, petsitter);
  }


  private handleError(err): Observable<never> {
    let errorMessage: string;
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Backend returned code ${err.status}: ${err.body.error}`;
    }
    console.error(err);
    return throwError(errorMessage);
  }

  private getHttpParamsFromObject(obj: unknown): HttpParams {
    let params = new HttpParams();

    Object.entries(obj).map(([k, v]) => {
      params = params.append(k, v);
    });
    return params;
  }
}


