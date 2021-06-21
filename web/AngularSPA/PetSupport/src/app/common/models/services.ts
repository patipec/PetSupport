export enum ServiceType {
  Boarding,
  HouseSitting,
  DogWalking,
  DropInVisit,
  Other,
}
export interface ServiceTypeDetails {
  type?: 'serviceTypeDetails';
  value: ServiceType;
  name: string;
  shortDescription: string;
  longDescription: string;
  icon: string;
}
export interface UserServiceType extends ServiceTypeDetails{
  price: number;
}
export interface UserServiceTypeShort {
  price: number;
  serviceType: ServiceType;
}
