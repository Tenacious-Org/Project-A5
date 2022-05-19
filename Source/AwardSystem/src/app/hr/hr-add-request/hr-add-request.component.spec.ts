import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HrAddRequestComponent } from './hr-add-request.component';

describe('HrAddRequestComponent', () => {
  let component: HrAddRequestComponent;
  let fixture: ComponentFixture<HrAddRequestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HrAddRequestComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HrAddRequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
