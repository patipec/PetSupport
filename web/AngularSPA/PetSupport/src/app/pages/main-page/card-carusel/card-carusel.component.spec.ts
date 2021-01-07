import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CardCaruselComponent } from './card-carusel.component';

describe('CardCaruselComponent', () => {
  let component: CardCaruselComponent;
  let fixture: ComponentFixture<CardCaruselComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CardCaruselComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CardCaruselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
