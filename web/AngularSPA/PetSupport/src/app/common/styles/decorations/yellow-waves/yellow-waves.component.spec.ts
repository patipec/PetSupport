import { ComponentFixture, TestBed } from '@angular/core/testing';

import { YellowWavesComponent } from './yellow-waves.component';

describe('YellowWavesComponent', () => {
  let component: YellowWavesComponent;
  let fixture: ComponentFixture<YellowWavesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ YellowWavesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(YellowWavesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
