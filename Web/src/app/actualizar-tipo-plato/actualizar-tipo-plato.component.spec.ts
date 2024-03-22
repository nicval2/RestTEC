import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActualizarTipoPlatoComponent } from './actualizar-tipo-plato.component';

describe('ActualizarTipoPlatoComponent', () => {
  let component: ActualizarTipoPlatoComponent;
  let fixture: ComponentFixture<ActualizarTipoPlatoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ActualizarTipoPlatoComponent]
    });
    fixture = TestBed.createComponent(ActualizarTipoPlatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
