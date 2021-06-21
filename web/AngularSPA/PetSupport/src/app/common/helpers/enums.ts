import {stringIsNumber} from './general';

export const enumToArray = <T>(enumme): T[] => Object.keys(enumme)
  .filter(stringIsNumber)
  .map(key => enumme[key]);
