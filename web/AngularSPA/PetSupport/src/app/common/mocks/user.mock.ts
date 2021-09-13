import {PetType, PetWeight} from '../models/pet-preferences';
import {ServiceType} from '../models/services';
import {User} from '../models/user';

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
