import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EndOfRegistrationComponent } from './end-of-registration.component';

describe('EndOfRegistrationComponent', () => {
  let component: EndOfRegistrationComponent;
  let fixture: ComponentFixture<EndOfRegistrationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EndOfRegistrationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EndOfRegistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
