import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IncorporateProyectionComponent } from './incorporate-proyection.component';

describe('IncorporateProyectionComponent', () => {
  let component: IncorporateProyectionComponent;
  let fixture: ComponentFixture<IncorporateProyectionComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IncorporateProyectionComponent]
    });
    fixture = TestBed.createComponent(IncorporateProyectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
