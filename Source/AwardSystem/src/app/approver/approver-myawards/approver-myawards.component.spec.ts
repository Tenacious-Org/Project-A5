import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApproverMyawardsComponent } from './approver-myawards.component';

describe('ApproverMyawardsComponent', () => {
  let component: ApproverMyawardsComponent;
  let fixture: ComponentFixture<ApproverMyawardsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApproverMyawardsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApproverMyawardsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
