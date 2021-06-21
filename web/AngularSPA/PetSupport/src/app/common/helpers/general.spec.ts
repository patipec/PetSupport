import {stringIsNumber} from './general';


describe('stringIsNumebr', () => {

  it('should return true if string is number', () => {
    expect(stringIsNumber('3')).toBe(true);
  });
});
