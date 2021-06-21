import {PetType, PetWeight} from '../models/pet-preferences';
import {ServiceType} from '../models/services';
import {Petsitter} from '../models/petsitter';

export const petsitterMock: Petsitter = {
  id: 1,
  name: 'John',
  surname: 'Doe',
  photoGallery: '',
  avatarId: '',
  city: 'Warsaw',
  basicPetsitterProfile: {
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
          PetWeight.Medium,
          PetWeight.Large,
          PetWeight.Huge,
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
