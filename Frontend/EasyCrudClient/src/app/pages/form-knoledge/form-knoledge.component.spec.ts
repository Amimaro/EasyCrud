import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormKnoledgeComponent } from './form-knoledge.component';

describe('FormKnoledgeComponent', () => {
  let component: FormKnoledgeComponent;
  let fixture: ComponentFixture<FormKnoledgeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormKnoledgeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormKnoledgeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
