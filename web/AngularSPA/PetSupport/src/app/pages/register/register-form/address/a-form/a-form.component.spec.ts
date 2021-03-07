import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AFormComponent } from './a-form.component';

describe('AFormComponent', () => {
  let component: AFormComponent;
  let fixture: ComponentFixture<AFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
