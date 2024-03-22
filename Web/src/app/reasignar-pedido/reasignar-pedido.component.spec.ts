import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReasignarPedidoComponent } from './reasignar-pedido.component';

describe('ReasignarPedidoComponent', () => {
  let component: ReasignarPedidoComponent;
  let fixture: ComponentFixture<ReasignarPedidoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ReasignarPedidoComponent]
    });
    fixture = TestBed.createComponent(ReasignarPedidoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
