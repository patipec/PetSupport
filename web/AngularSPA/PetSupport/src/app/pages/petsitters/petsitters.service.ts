import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable, of, throwError} from 'rxjs';
import {catchError, map, tap} from 'rxjs/operators';
import {Petsitter, PetsitterCreate, PetsitterUpdate} from '../../common/models/petsitter';
import {FindPetsitterForm, FindPetsitterLongForm, FindPetsitterShortForm} from '../../common/models/forms';

const PETSITTER_URL = 'http://localhost:5001/api/Petsitters'


@Injectable({
  providedIn: 'root'
})
export class PetsittersService {

  constructor(private http: HttpClient) {
  }


  public getPetsitters(formData: FindPetsitterShortForm): Observable<Petsitter[]> {
    console.log(formData);
    let params = new HttpParams();
    Object.entries(formData).map(([k, v ]) => {
      console.log(k, v);
      params = params.append(k, v);
    });
    console.log(params);

    return this.http.get<Petsitter[]>(PETSITTER_URL, {params})
      .pipe(
        tap(data => console.log(data)),
        catchError(this.handleError)
      );
  }

  public getFilteredPetsittersByShortForm(formData: FindPetsitterShortForm): Observable<Petsitter[]> {
    return this.http.post<Petsitter[]>(PETSITTER_URL, formData); // :TODO should be get, but het cant take body
  }

  public getFilteredPetsittersByLongForm(formData: FindPetsitterLongForm): Observable<Petsitter[]> {
    return this.http.post<Petsitter[]>(PETSITTER_URL, formData); // :TODO should be get, but het cant take body
  }

  // public getPetsitter(petsitterId: number): Observable<Petsitter> {
  //   return this.getPetsitters()
  //     .pipe(
  //       map(data => data.find(pet => pet.Id === petsitterId))
  //     );
    // return this.http.get<Petsitter>(`${PETSITTER_URL}/${petsitterId}`);
  //}

  public createPetsitter(petsitter: PetsitterCreate): Observable<Petsitter> {
    return this.http.post<Petsitter>(PETSITTER_URL, petsitter);
  }
  public updatePetsitter(petsitter: PetsitterUpdate): Observable<Petsitter> {
    return this.http.put<Petsitter>(PETSITTER_URL, petsitter);
  }

  // sendForm(petsitter: Petsitter): Observable<Petsitter> {
  //   const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
  //   petsitter.Id = null;
  //   return this.http.post<Petsitter>(this.petsittersUrl, petsitter, { headers })
  //     .pipe(
  //       tap(data => console.log('createProduct: ' + JSON.stringify(data))),
  //       catchError(this.handleError)
  //     );
  // }

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
}


