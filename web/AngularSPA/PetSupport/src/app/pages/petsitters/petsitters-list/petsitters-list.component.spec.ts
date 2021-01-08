import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PetsittersListComponent } from './petsitters-list.component';

describe('PetsittersListComponent', () => {
  let component: PetsittersListComponent;
  let fixture: ComponentFixture<PetsittersListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PetsittersListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PetsittersListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
