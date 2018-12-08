import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TableScheduleComponent } from './table-schedule.component';

describe('TableScheduleComponent', () => {
  let component: TableScheduleComponent;
  let fixture: ComponentFixture<TableScheduleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TableScheduleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TableScheduleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
