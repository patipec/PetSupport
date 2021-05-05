import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleServiceInputComponent } from './single-service-input.component';

describe('SingleServiceInputComponent', () => {
  let component: SingleServiceInputComponent;
  let fixture: ComponentFixture<SingleServiceInputComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleServiceInputComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleServiceInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
