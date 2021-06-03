export enum ServiceType {
  Boarding,
  HouseSitting,
  DogWalking,
  DropInVisit,
  Other,
}
export interface ServiceTypeDetails {
  serviceType: ServiceType;
  name: string;
  shortDescription: string;
  longDescription: string;
}
export interface UserServiceType extends  ServiceTypeDetails{
  price: number;
}
const serviceTypeDetails: Partial<Record<ServiceType, ServiceTypeDetails>> = {
  [ServiceType.Boarding]: {
    serviceType: ServiceType.Boarding,
    name: 'Boarding',
    shortDescription: 'Lorem',
    longDescription: 'Lorem Ipsum',
  },
  [ServiceType.HouseSitting]: {
    serviceType: ServiceType.HouseSitting,
    name: 'Boarding',
    shortDescription: 'Lorem',
    longDescription: 'Lorem Ipsum',
  },
  [ServiceType.DogWalking]: {
    serviceType: ServiceType.DogWalking,
    name: 'Boarding',
    shortDescription: 'Lorem',
    longDescription: 'Lorem Ipsum',
  },
  [ServiceType.DropInVisit]: {
    serviceType: ServiceType.DropInVisit,
    name: 'Boarding',
    shortDescription: 'Lorem',
    longDescription: 'Lorem Ipsum',
  },
  [ServiceType.Other]: {
    serviceType: ServiceType.Other,
    name: 'Boarding',
    shortDescription: 'Lorem',
    longDescription: 'Lorem Ipsum',
  }
};
export const servicesUtils = {};

