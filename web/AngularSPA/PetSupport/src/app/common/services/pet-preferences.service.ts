import {Injectable} from '@angular/core';
import {PetPreferenceInformation, PetType, PetWeight} from '../models/pet-preferences';
import {PetPreference} from '../models/user';
import {enumToArray} from '../helpers/enums';
import {FormBuilder, FormGroup} from '@angular/forms';
import {UserQuery} from '../../pages/user/state/user.query';

@Injectable({
  providedIn: 'root'
})
export class PetPreferencesService {
  private sizesNames = {
    [PetWeight.Tiny]: 'Tiny',
    [PetWeight.Small]: 'Small',
    [PetWeight.Medium]: 'Medium',
    [PetWeight.Large]: 'Large',
    [PetWeight.Huge]: 'Huge',
  };
  private icons = {
    [PetType.Dog]: '/assets/shortFormImages/cocker-spaniel.png',
    [PetType.Cat]: '/assets/shortFormImages/dog-smiley.png',
  };
  private petTypeNames = {
    [PetType.Dog]: 'Dog',
    [PetType.Cat]: 'Cat',
  };
  private allOptions: PetPreference[] = [
    {petType: PetType.Dog, petWeights: enumToArray(PetWeight)},
    {petType: PetType.Cat, petWeights: enumToArray(PetWeight)}
  ];
  private petTypeToPetWeightMapper: Partial<Record<PetType, Record<PetWeight, string>>> = {
    [PetType.Dog]: {
      ...PetPreferencesService.createWeightsDescriptions([5, 10, 20, 30])
    },
    [PetType.Cat]: {
      ...PetPreferencesService.createWeightsDescriptions([2, 5, 8, 12])
    }
  };

  constructor(private fb: FormBuilder, private userQuery: UserQuery) {
  }

  private static createWeightsDescriptions(bps: number[]): Record<PetWeight, string> {
    /*Array with 4 values breakpoints,*/
    return {
      [PetWeight.Tiny]: bps[0] + ' > kg',
      [PetWeight.Small]: `${bps[0]}-${bps[1]}kg`,
      [PetWeight.Medium]: `${bps[1]}-${bps[2]}kg`,
      [PetWeight.Large]: `${bps[2]}-${bps[3]}kg`,
      [PetWeight.Huge]: bps[3] + ' < kg',
    };
  }

  public getAllOptions(): PetPreferenceInformation[] {
    return this.mapPetPreferences(this.allOptions);
  }

  public getPetPreferenceForm(): FormGroup {
    const obj = {} as Record<PetType, number[]>;
    this.getAllOptions().map(petPreference => obj[petPreference.petType] = [] as number[]);
    return this.fb.group(obj);
  }

  public fillPetPreferenceFormWithUserData(petPreferenceForm: FormGroup): void {
    this.userQuery.petPreferences$.subscribe(c => {
      c.map(petPreferences => {
        petPreferenceForm.controls[petPreferences.petType].patchValue(petPreferences.petWeights);
      });
    });
  }

  private mapPetPreferences(petPreferences: PetPreference[]): PetPreferenceInformation[] {
    return petPreferences.map(petPreference => ({
        type: 'petPreferenceInformation',
        petType: petPreference.petType,
        icon: this.icons[petPreference.petType],
        petTypeName: this.petTypeNames[petPreference.petType],
        petInformation: petPreference.petWeights.map(petWeight => ({
          type: 'petInformation',
          petWeight,
          sizeDescription: this.petTypeToPetWeightMapper[petPreference.petType][petWeight],
          sizeName: this.sizesNames[petWeight],
        }))
      })
    );
  }


}
