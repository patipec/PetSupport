import {NgControl} from '@angular/forms';
import {Directive, Input, OnInit} from '@angular/core';

@Directive({
  selector: '[appDisableControl]',
})
export class DisableControlDirective implements OnInit {
  @Input() set appDisableControl(condition: boolean) {
    if (this.disabled !== undefined) {
      this.toggleForm(condition);
    }
    this.disabled = condition;
  }

  disabled: boolean;

  constructor(private ngControl: NgControl) {
  }

  public ngOnInit(): void {
    this.toggleForm(this.disabled);
  }

  public toggleForm(condition: boolean): void {
    const action = condition ? 'disable' : 'enable';
    this.ngControl.control[action]();
  }
}
