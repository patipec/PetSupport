export const toggleValueFromArray = <T>(array: T[], value: T): T[] => {
  /*
  @Example:
    ([1, 2, 3], 3) => [1, 2]
    ([1, 2, 4], 3) => [1, 2, 4, 3]
  * */
  array = [...array];
  const index = array.findIndex(item => item === value);
  if (index !== -1) {
    array.splice(index, 1);
  } else if (index !== undefined) {
    array.push(value);
  }
  return array;
};
