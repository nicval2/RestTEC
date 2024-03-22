import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IncorporateScreenComponent } from './incorporate-screen.component';

describe('IncorporateScreenComponent', () => {
  let component: IncorporateScreenComponent;
  let fixture: ComponentFixture<IncorporateScreenComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IncorporateScreenComponent]
    });
    fixture = TestBed.createComponent(IncorporateScreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
