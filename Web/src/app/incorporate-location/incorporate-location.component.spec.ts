import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IncorporateLocationComponent } from './incorporate-location.component';

describe('IncorporateLocationComponent', () => {
  let component: IncorporateLocationComponent;
  let fixture: ComponentFixture<IncorporateLocationComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IncorporateLocationComponent]
    });
    fixture = TestBed.createComponent(IncorporateLocationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
