import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {tap} from 'rxjs/operators';
import {Petsitter, PetsitterCreate, PetsitterUpdate} from '../../common/models/old-models/petsitter';
import {FindPetsitterShortForm} from '../../common/models/old-models/forms';
import {HttpService} from '../../common/services/http.service';

const PETSITTER_URL = 'Petsitters';

@Injectable({
  providedIn: 'root'
})
export class PetsittersService {
  constructor(private http: HttpService) {
  }
  public getPetsitters(formData: FindPetsitterShortForm): Observable<Petsitter[]> {
    const params = this.http.objectToParams(formData);

    return this.http.get<Petsitter[]>(PETSITTER_URL, {params})
      .pipe(tap(data => console.log(data)));
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
}


