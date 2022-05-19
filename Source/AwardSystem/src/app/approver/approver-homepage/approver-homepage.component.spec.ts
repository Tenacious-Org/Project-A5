import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApproverHomepageComponent } from './approver-homepage.component';

describe('ApproverHomepageComponent', () => {
  let component: ApproverHomepageComponent;
  let fixture: ComponentFixture<ApproverHomepageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApproverHomepageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApproverHomepageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
