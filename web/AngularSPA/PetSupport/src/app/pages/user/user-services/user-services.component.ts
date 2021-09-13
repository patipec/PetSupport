import {Component, OnInit} from '@angular/core';
import {FormBuilder} from '@angular/forms';
import {PetType} from '../../../common/models/pet-preferences';
import {PetPreference} from '../../../common/models/user';
import {PetPreferencesService} from '../../../common/services/pet-preferences.service';
import {toggleArrayValueFromFormControl} from '../../../common/helpers/forms';
import {PetsitterServicesService} from '../../../common/services/petsitter-services.service';
import {UserServiceTypeShort} from '../../../common/models/services';

@Component({
  selector: 'app-user-services',
  templateUrl: './user-services.component.html',
  styleUrls: ['./user-services.component.scss']
})
export class UserServicesComponent implements OnInit {
  public chosenPetTypes = 0;
  public petPreferences = this.petPreferencesService.getAllOptions();
  public services = this.petsitterServicesService.getAsList();

  public form = this.fb.group({services: []});
  public priceForm = this.petsitterServicesService.createPriceForm();
  public petPreferenceForm = this.petPreferencesService.getPetPreferenceForm();

  constructor(
    private fb: FormBuilder,
    private petPreferencesService: PetPreferencesService,
    private petsitterServicesService: PetsitterServicesService) {
  }

  public ngOnInit(): void {
    this.petsitterServicesService.fillServicesFormsWithUserData(this.form, this.priceForm);
    this.petPreferencesService.fillPetPreferenceFormWithUserData(this.petPreferenceForm);
  }

  public changeChosenService(value: number): void {
    toggleArrayValueFromFormControl<number>(this.form.get('services'), value);
  }

  public changeChosenPetWeight(value: number, petType: PetType): void {
    toggleArrayValueFromFormControl<number>(this.petPreferenceForm.controls[petType], value);
  }

  public changeChosenPetType(value: number): void {
    this.chosenPetTypes = value;
  }

  public getFormsValue(): { petPreferences: PetPreference[], userServices: UserServiceTypeShort[] } {
    /*To refactor -> Move it to service*/
    return {
      userServices: this.form.value.services.map(v => ({serviceType: v, price: +this.priceForm.value[v]})),
      petPreferences: Object.entries(this.petPreferenceForm.value)
        .map(([key, value]) =>
          ({petType: +key, petWeights: value})) as PetPreference[],
    };
  }


}
