import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserWrapperComponent } from './user-wrapper.component';

describe('UserWrapperComponent', () => {
  let component: UserWrapperComponent;
  let fixture: ComponentFixture<UserWrapperComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserWrapperComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserWrapperComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
