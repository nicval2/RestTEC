import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TomarPedidoComponent } from './tomar-pedido.component';

describe('TomarPedidoComponent', () => {
  let component: TomarPedidoComponent;
  let fixture: ComponentFixture<TomarPedidoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TomarPedidoComponent]
    });
    fixture = TestBed.createComponent(TomarPedidoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
