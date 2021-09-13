import {Injectable} from '@angular/core';
import {Store, StoreConfig} from '@datorama/akita';
import {BasicPetsitterProfile, UserAddressDetails, UserBasicInfo} from '../../../common/models/user';
import {userMock} from '../../../common/mocks/user.mock';

export interface UserState {
  id: number;
  basicInfo: UserBasicInfo;
  addressDetails?: UserAddressDetails;
  basicPetsitterProfile?: BasicPetsitterProfile;
}

export function createInitialState(): UserState {
  return userMock;
}

@Injectable({providedIn: 'root'})
@StoreConfig({name: 'user'})
export class UserStore extends Store<UserState> {

  constructor() {
    super(createInitialState());
  }

}
