import {Directive, ElementRef, HostListener, Output, EventEmitter} from '@angular/core';

@Directive({
  selector: 'input[appInput], textarea[appInput]',
})
export class InputDirective {
  @Output()
  public eventEmitter = new EventEmitter();
/*  @HostListener('focus', ['$event.target'])
  public onFocus(btn): void {
    console.log('button', btn, 'number of clicks:');
    this.eventEmitter.emit(btn);
  }*/
  constructor(public el: ElementRef<HTMLInputElement | HTMLTextAreaElement>) {
  }
}
