export interface Petsitter extends PetsitterUpdate {
  Services?: {}; //  TODO Services[]
  Reviews?: [
    {
      ReviewerFirstName: string;
      ReviewerSurName: string;
      ReviewerComment: string;
      ReviewerRate: number;
      ReviewDate: Date;
      ReviewerImage: string;
    }]; //  TODO Reviews[]
  PetsitterCanHost: {
    small: string;
    medium: string;
    large: string;
    cat: string;
  };
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
