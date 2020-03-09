import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DEMO1Component } from './demo1.component';

describe('DEMO1Component', () => {
  let component: DEMO1Component;
  let fixture: ComponentFixture<DEMO1Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DEMO1Component ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DEMO1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
