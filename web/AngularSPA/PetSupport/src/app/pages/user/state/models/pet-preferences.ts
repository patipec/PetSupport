import {PetPreference} from './user';

export enum PetType {
  Cat,
  Dog,
  Other,
}

export enum PetWeight {
  Tiny,
  Small,
  Medium,
  Large,
  Huge,
}

export interface PetPreferenceInformation {
  petType: PetType;
  petInformation: {
    petWeight: PetWeight;
    sizeName: string;
    sizeDescription: string
  }[]
}

const sizesNames = {
  [PetWeight.Tiny]: 'Tiny',
  [PetWeight.Small]: 'Small',
  [PetWeight.Medium]: 'Medium',
  [PetWeight.Large]: 'Large',
  [PetWeight.Huge]: 'Huge',
};

const petTypeToPetWeightMapper: Partial<Record<PetType, Record<PetWeight, string>>> = {
  [PetType.Dog]: {
    [PetWeight.Tiny]: 'do 5kg',
    [PetWeight.Small]: 'od 5kg do 10kg',
    [PetWeight.Medium]: 'od 10 do 20kg',
    [PetWeight.Large]: 'od 20 do 30kg',
    [PetWeight.Huge]: 'powyżej 30kg',
  },
  [PetType.Cat]: {
    [PetWeight.Tiny]: 'do 2kg',
    [PetWeight.Small]: 'od 2kg do 5kg',
    [PetWeight.Medium]: 'od 5 do 8kg',
    [PetWeight.Large]: 'od 8 do 12g',
    [PetWeight.Huge]: 'powyżej 12kg',
  }
};

const mapPetPreferences = (petPreferences: PetPreference[]): PetPreferenceInformation[] =>
  petPreferences.map(petPreference => ({
      petType: petPreference.petType,
      petInformation: petPreference.petWeights.map(petWeight => ({
        petWeight,
        sizeDescription: petTypeToPetWeightMapper[petPreference.petType][petWeight],
        sizeName: sizesNames[petWeight],
      }))
    })
  );


export const petPreferencesUtils = {
  mapPetPreferences,
};
