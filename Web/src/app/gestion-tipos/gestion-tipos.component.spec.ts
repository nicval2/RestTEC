import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionTiposComponent } from './gestion-tipos.component';

describe('GestionTiposComponent', () => {
  let component: GestionTiposComponent;
  let fixture: ComponentFixture<GestionTiposComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GestionTiposComponent]
    });
    fixture = TestBed.createComponent(GestionTiposComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
