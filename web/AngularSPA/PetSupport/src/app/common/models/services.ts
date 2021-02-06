export enum Services {
  Boarding,
  HouseSitting,
  DogWalking,
  DropInVisit,
  DoggyDayCare
}

export const fromEnum = (en: object): { name: string, label: string, key: number }[] => {
  const array = Object.entries(en);
  const singleValuesPair = array.slice(array.length / 2, array.length);
  const transformed = singleValuesPair.map(([value, key]) => {
    const splitName = value.split(/(?=[A-Z])/);

    const label = splitName.join('');
    const name = splitName.join(' ');
    return {name, label, key};
  });
  return transformed;
};
