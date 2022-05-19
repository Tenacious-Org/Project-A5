import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApproverAddrequestComponent } from './approver-addrequest.component';

describe('ApproverAddrequestComponent', () => {
  let component: ApproverAddrequestComponent;
  let fixture: ComponentFixture<ApproverAddrequestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApproverAddrequestComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApproverAddrequestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
