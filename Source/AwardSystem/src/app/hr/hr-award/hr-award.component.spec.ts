import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HrAwardComponent } from './hr-award.component';

describe('HrAwardComponent', () => {
  let component: HrAwardComponent;
  let fixture: ComponentFixture<HrAwardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HrAwardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HrAwardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
