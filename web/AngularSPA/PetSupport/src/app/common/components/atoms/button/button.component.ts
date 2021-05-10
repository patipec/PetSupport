import {Component, ElementRef, Input, OnInit, Renderer2} from '@angular/core';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'a[appButton], button[appButton]',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.scss']
})
export class ButtonComponent implements OnInit {

  @Input('appButton')
  set appButton(value: 'warn' | 'error') {
    let color: string;
    if (value === 'error') {
      color = 'red';
    }
    if (value === 'warn') {
      color = 'orange';
    }
    // tslint:disable-next-line:no-unused-expression
    color && this.renderer.setStyle(this.host.nativeElement, 'backgroundColor', color);

  }

  constructor(private host: ElementRef<HTMLButtonElement | HTMLAnchorElement>, private renderer: Renderer2) {
  }

  public ngOnInit(): void {
  }

}
