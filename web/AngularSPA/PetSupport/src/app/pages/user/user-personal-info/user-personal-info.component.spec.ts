import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserPersonalInfoComponent } from './user-personal-info.component';

describe('UserPersonalInfoComponent', () => {
  let component: UserPersonalInfoComponent;
  let fixture: ComponentFixture<UserPersonalInfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserPersonalInfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserPersonalInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
