import {ServiceType} from './services';
import {PetType, PetWeight} from './pet-preferences';

export const userMock: User = {
  id: 1,
  basicInfo: {
    name: 'John',
    surname: 'Doe',
    email: 'john.doe@gmail.com',
    phoneNumber: '444555666',
    isProfileCompleted: true,
    wantsToBePetsitter: false,
    photoGallery: '',
    avatarId: '',
  },
  addressDetails: {
    city: 'Warsaw',
    street: 'Street',
    houseNumber: '50',
    flatNumber: '4',
    zipCode: '44-666',
    country: 'Poland',
    latitude: 49,
    longitude: 21,
    range: 50,
  },
  basicPetsitterProfile: {
    dateOfBirth: new Date(1000000),
    petPreferences: [
      {
        petType: PetType.Dog,
        petWeights: [
          PetWeight.Tiny,
          PetWeight.Small,
          PetWeight.Large
        ]
      },
      {
        petType: PetType.Cat,
        petWeights: [
          PetWeight.Tiny,
          PetWeight.Small,
          PetWeight.Large,
          PetWeight.Huge,
          PetWeight.Large
        ]
      }
    ],
    petServices: [
      {
        price: 40,
        serviceType: ServiceType.HouseSitting,
      },
      {
        price: 50,
        serviceType: ServiceType.Boarding
      }
    ],
    shortDescription: 'Lorem',
    experience: 'Lorem',
    availability: 'Lorem',
    environment: 'Lorem',
  }
};

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

