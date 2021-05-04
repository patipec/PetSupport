import {Directive, ElementRef, HostListener, Output, EventEmitter} from '@angular/core';

@Directive({
  selector: 'input[appInput], textarea[appInput]',
})
export class InputDirective {
  constructor() {}
}
