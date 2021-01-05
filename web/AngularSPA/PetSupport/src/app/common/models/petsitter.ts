 export interface Petsitter {
  Id: number;
  Name: string;
  Surname: string;
   coordinates: {
     lat: number
     lon: number
   };
  ImageId: string;
  City: string;
  Description: string;
  Price: number;
}
