import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BecomePetsitterComponent } from './become-petsitter.component';

describe('BecomePetsitterComponent', () => {
  let component: BecomePetsitterComponent;
  let fixture: ComponentFixture<BecomePetsitterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BecomePetsitterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BecomePetsitterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
