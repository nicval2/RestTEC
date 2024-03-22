import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearTipoPlatoComponent } from './crear-tipo-plato.component';

describe('CrearTipoPlatoComponent', () => {
  let component: CrearTipoPlatoComponent;
  let fixture: ComponentFixture<CrearTipoPlatoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CrearTipoPlatoComponent]
    });
    fixture = TestBed.createComponent(CrearTipoPlatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
