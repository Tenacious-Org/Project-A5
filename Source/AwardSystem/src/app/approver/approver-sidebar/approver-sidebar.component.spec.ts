import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApproverSidebarComponent } from './approver-sidebar.component';

describe('ApproverSidebarComponent', () => {
  let component: ApproverSidebarComponent;
  let fixture: ComponentFixture<ApproverSidebarComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ApproverSidebarComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ApproverSidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
