import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminbuttonsComponent } from './adminbuttons.component';

describe('AdminbuttonsComponent', () => {
  let component: AdminbuttonsComponent;
  let fixture: ComponentFixture<AdminbuttonsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminbuttonsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminbuttonsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
