export interface Petsitter extends PetsitterUpdate {
  Services?: string[]; //  TODO Services[]
}

export interface PetsitterCreate extends Petsitter {
  PhoneNumber: string;
}

export interface PetsitterUpdate {
  Id: number;
  Name: string;
  Surname: string;
  ImageId: string;
  Address?: string;
  City: string;
  ZipCode?: string;
  Description: string;
  Price: number;
  Rate: number;
}
