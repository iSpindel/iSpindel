import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BrewCalculatorsComponent } from './brew-calculators.component';

describe('BrewCalculatorsComponent', () => {
  let component: BrewCalculatorsComponent;
  let fixture: ComponentFixture<BrewCalculatorsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BrewCalculatorsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BrewCalculatorsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
