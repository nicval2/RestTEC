import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProyectionSelectionComponent } from './proyection-selection.component';

describe('ProyectionSelectionComponent', () => {
  let component: ProyectionSelectionComponent;
  let fixture: ComponentFixture<ProyectionSelectionComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ProyectionSelectionComponent]
    });
    fixture = TestBed.createComponent(ProyectionSelectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
