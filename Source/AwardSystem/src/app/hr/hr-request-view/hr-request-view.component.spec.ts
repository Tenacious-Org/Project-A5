import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HrRequestViewComponent } from './hr-request-view.component';

describe('HrRequestViewComponent', () => {
  let component: HrRequestViewComponent;
  let fixture: ComponentFixture<HrRequestViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HrRequestViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HrRequestViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
