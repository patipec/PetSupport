import { Injectable } from '@angular/core';
import { Query } from '@datorama/akita';
import { UserStore, UserState } from './user.store';
import {map} from 'rxjs/operators';

@Injectable({ providedIn: 'root' })
export class UserQuery extends Query<UserState> {
  user$ = this.select();
  wantsToBePetsitter$ = this.select('basicInfo')
    .pipe(map(bi => bi.wantsToBePetsitter));
  basicInfo$ = this.select('basicInfo');
  addressDetails$ = this.select('addressDetails');
  petsitterProfile$ = this.select('basicPetsitterProfile');
  petPreferences$ = this.petsitterProfile$.pipe(map(petsitterProfile => petsitterProfile.petPreferences));
  petServices$ = this.petsitterProfile$.pipe(map(petsitterProfile => petsitterProfile.petServices));

  constructor(protected store: UserStore) {
    super(store);
  }
}
