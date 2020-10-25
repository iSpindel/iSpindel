import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListMeasuresComponent } from './list-measures.component';

describe('ListMeasuresComponent', () => {
  let component: ListMeasuresComponent;
  let fixture: ComponentFixture<ListMeasuresComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListMeasuresComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListMeasuresComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
