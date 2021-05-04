import {Directive, ElementRef} from '@angular/core';

@Directive({
  selector: 'label[appLabel]'
})
export class LabelDirective {

  constructor(public el: ElementRef<HTMLLabelElement>) {
  }

}
