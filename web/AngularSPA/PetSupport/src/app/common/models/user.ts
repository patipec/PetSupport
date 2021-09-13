import {ServiceType} from './services';
import {PetType, PetWeight} from './pet-preferences';

export interface User {
  id: number;
  basicInfo: UserBasicInfo;
  addressDetails?: UserAddressDetails;
  basicPetsitterProfile?: BasicPetsitterProfile;
}

export interface UserBasicInfo {
  photoGallery: string;
  isProfileCompleted: boolean;
  avatarId: string;
  name: string;
  surname: string;
  email: string;
  phoneNumber: string;
  wantsToBePetsitter: boolean;
}

export interface UserAddressDetails {
  city: string;
  street: string;
  houseNumber: string;
  flatNumber: string;
  zipCode: string;
  country: string;
  latitude: number;
  longitude: number;
  range?: number;
}

export interface BasicPetsitterProfile {
  dateOfBirth: Date;
  petPreferences: PetPreference[];
  petServices: PetService[];
  shortDescription: string;
  experience: string;
  availability: string;
  environment: string;
}


export interface PetService {
  price: number;
  serviceType: ServiceType;
}

export interface PetPreference {
  petType: PetType;
  petWeights: PetWeight[];
}

