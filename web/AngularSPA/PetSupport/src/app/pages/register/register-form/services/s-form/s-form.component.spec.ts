import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SFormComponent } from './s-form.component';

describe('SFormComponent', () => {
  let component: SFormComponent;
  let fixture: ComponentFixture<SFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
