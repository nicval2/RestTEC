import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActualizarPlatoComponent } from './actualizar-plato.component';

describe('ActualizarPlatoComponent', () => {
  let component: ActualizarPlatoComponent;
  let fixture: ComponentFixture<ActualizarPlatoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ActualizarPlatoComponent]
    });
    fixture = TestBed.createComponent(ActualizarPlatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
