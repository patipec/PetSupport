export interface FindPetsitterShortForm {
  city: string;
  serviceId: string;
}


export interface FindPetsitterLongForm {
  address: string;
  city: string;
  serviceId: number;
  minPrice: number;
  maxPrice: number;
}

export type FindPetsitterForm = FindPetsitterLongForm | FindPetsitterShortForm;
