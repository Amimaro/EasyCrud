import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormOccupationComponent } from './form-occupation.component';

describe('FormOccupationComponent', () => {
  let component: FormOccupationComponent;
  let fixture: ComponentFixture<FormOccupationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormOccupationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormOccupationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
