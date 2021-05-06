import {Component, Input, OnInit} from '@angular/core';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'a[appButtonIcon], button[appButtonIcon]',
  templateUrl: './button-icon.component.html',
  styleUrls: ['./button-icon.component.scss']
})
export class ButtonIconComponent implements OnInit {
  @Input()
  public buttonIconSrc = '/assets/calendar.png';
  @Input()
  public buttonIconHeight = '20';
  @Input()
  public buttonIconWidth = '20';

  constructor() {
  }

  ngOnInit(): void {
  }

}
