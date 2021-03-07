import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PiFormComponent } from './pi-form.component';

describe('PiFormComponent', () => {
  let component: PiFormComponent;
  let fixture: ComponentFixture<PiFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PiFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PiFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
