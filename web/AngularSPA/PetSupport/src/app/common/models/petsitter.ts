import {UserServiceTypeShort} from './services';
import {PetPreference} from './user';

export interface Petsitter {
  id: number;
  name: string;
  surname: string;
  avatarId: string;
  city: string;
  photoGallery: string;
  basicPetsitterProfile: {
    shortDescription: string;
    availability: string;
    environment: string;
    experience: string;
    petServices: UserServiceTypeShort[];
    petPreferences: PetPreference[];
  };
}
