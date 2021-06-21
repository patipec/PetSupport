export enum PetType {
  Dog,
  Cat,
  Other,
}

export enum PetWeight {
  Tiny,
  Small,
  Medium,
  Large,
  Huge,
}
export interface PetInformation {
  type?: 'petInformation';
  petWeight: PetWeight;
  sizeName: string;
  sizeDescription: string;
}
export interface PetPreferenceInformation {
  type?: 'petPreferenceInformation';
  petType: PetType;
  petTypeName: string;
  icon: string;
  petInformation: PetInformation[];
}
