import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CurrentMeasureComponent } from './current-measure.component';

describe('CurrentMeasureComponent', () => {
  let component: CurrentMeasureComponent;
  let fixture: ComponentFixture<CurrentMeasureComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CurrentMeasureComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CurrentMeasureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
