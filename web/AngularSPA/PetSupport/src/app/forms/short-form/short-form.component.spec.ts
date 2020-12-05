import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShortFormComponent } from './short-form.component';

describe('ShortFormComponent', () => {
  let component: ShortFormComponent;
  let fixture: ComponentFixture<ShortFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShortFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShortFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
