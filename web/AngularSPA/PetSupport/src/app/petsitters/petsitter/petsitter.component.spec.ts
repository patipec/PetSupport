import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PetsitterComponent } from './petsitter.component';

describe('PetsitterComponent', () => {
  let component: PetsitterComponent;
  let fixture: ComponentFixture<PetsitterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PetsitterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PetsitterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
