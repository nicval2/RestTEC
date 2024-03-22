import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestionPedidoComponent } from './gestion-pedido.component';

describe('GestionPedidoComponent', () => {
  let component: GestionPedidoComponent;
  let fixture: ComponentFixture<GestionPedidoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GestionPedidoComponent]
    });
    fixture = TestBed.createComponent(GestionPedidoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
