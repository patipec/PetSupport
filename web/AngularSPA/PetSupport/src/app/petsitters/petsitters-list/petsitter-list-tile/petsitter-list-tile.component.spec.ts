import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PetsitterListTileComponent } from './petsitter-list-tile.component';

describe('PetsitterListTileComponent', () => {
  let component: PetsitterListTileComponent;
  let fixture: ComponentFixture<PetsitterListTileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PetsitterListTileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PetsitterListTileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
