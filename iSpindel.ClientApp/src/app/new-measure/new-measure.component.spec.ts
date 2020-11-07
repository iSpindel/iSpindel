import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewMeasureComponent } from './new-measure.component';

describe('NewMeasureComponent', () => {
  let component: NewMeasureComponent;
  let fixture: ComponentFixture<NewMeasureComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewMeasureComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewMeasureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
