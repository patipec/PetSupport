import {Injectable} from '@angular/core';
import {ServiceType, ServiceTypeDetails, UserServiceType, UserServiceTypeShort} from '../models/services';
import {enumToArray} from '../helpers/enums';
import {FormBuilder, FormGroup} from '@angular/forms';
import {UserQuery} from '../../pages/user/state/user.query';
import {PetService} from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class PetsitterServicesService {
  private serviceTypeDetails: Partial<Record<ServiceType, ServiceTypeDetails>> = {
    [ServiceType.Boarding]: {
      type: 'serviceTypeDetails',
      value: ServiceType.Boarding,
      name: 'Boarding',
      shortDescription: 'Lorem',
      longDescription: 'Lorem Ipsum',
      icon: '/assets/shortFormImages/cocker-spaniel.png'
    },
    [ServiceType.HouseSitting]: {
      type: 'serviceTypeDetails',
      value: ServiceType.HouseSitting,
      name: 'House Sitting',
      shortDescription: 'Lorem',
      longDescription: 'Lorem Ipsum',
      icon: '/assets/shortFormImages/dog-heart.png'
    },
    [ServiceType.DogWalking]: {
      type: 'serviceTypeDetails',
      value: ServiceType.DogWalking,
      name: 'Dog Walking',
      shortDescription: 'Lorem',
      longDescription: 'Lorem Ipsum',
      icon: '/assets/shortFormImages/dog-smiley.png',
    },
    [ServiceType.DropInVisit]: {
      type: 'serviceTypeDetails',
      value: ServiceType.DropInVisit,
      name: 'Drop in Visit',
      shortDescription: 'Lorem',
      longDescription: 'Lorem Ipsum',
      icon: '/assets/shortFormImages/dog-smiley.png',
    },
    [ServiceType.Other]: {
      type: 'serviceTypeDetails',
      value: ServiceType.Other,
      name: 'Other',
      shortDescription: 'Lorem',
      longDescription: 'Lorem Ipsum',
      icon: '/assets/shortFormImages/dog-smiley.png',
    }
  };
  private allServices = enumToArray<ServiceType>(ServiceType);

  constructor(private fb: FormBuilder, private userQuery: UserQuery) {
  }

  public getAsList = (services: ServiceType[] = this.allServices): ServiceTypeDetails[] =>
    services.map(service => this.serviceTypeDetails[service])

  public fillServicesFormsWithUserData(servicesForm: FormGroup, priceForm: FormGroup): void {
    this.userQuery.petServices$.subscribe(petServices => {
      servicesForm.get('services').patchValue(petServices.map(o => o.serviceType));
      priceForm.patchValue(this.mergePetServicesToObject(petServices));
    });
  }

  public createPriceForm(userServiceType = this.getInitialUserService()): FormGroup {
    const obj = {} as Record<ServiceType, number[]>;
    userServiceType.map(serviceType => obj[serviceType.serviceType] = [serviceType.price]);
    return this.fb.group(obj);
  }

  private getInitialUserService = (): UserServiceTypeShort[] => this.allServices.map(s => ({serviceType: s, price: 25}));

  private mergePetServicesToObject = (petServices: PetService[]): PetService =>
    petServices.reduce((acc, curr) => {
      acc[curr.serviceType] = curr.price;
      return acc;
    }, {} as PetService);


}
