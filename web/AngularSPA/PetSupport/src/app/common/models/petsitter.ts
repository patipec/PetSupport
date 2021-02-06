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
  coordinates: {lattiude, longtitude}[];
}

export interface PetsitterCreate extends Petsitter {
  PhoneNumber: string;
}

export interface PetsitterUpdate {
  id: number;
  name: string;
  surname: string;
  imageId: string;
  address?: string;
  city: string;
  zipCode?: string;
  description: string;
  price: number;
  rate: number;
}
