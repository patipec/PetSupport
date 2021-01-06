export interface FindPetsitterShortForm {
  City: string;
  ServiceId: string;
}


export interface FindPetsitterLongForm {
  Address: string;
  City: string;
  ServiceId: number;
  MinPrice: number;
  MaxPrice: number;
}

export type FindPetsitterForm = FindPetsitterLongForm | FindPetsitterShortForm;
