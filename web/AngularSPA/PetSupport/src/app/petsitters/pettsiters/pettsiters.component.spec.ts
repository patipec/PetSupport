import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { PettsitersComponent } from './pettsiters.component';

describe('PettsitersComponent', () => {
  let component: PettsitersComponent;
  let fixture: ComponentFixture<PettsitersComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ PettsitersComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PettsitersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
