import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EliminarTipoPlatoComponent } from './eliminar-tipo-plato.component';

describe('EliminarTipoPlatoComponent', () => {
  let component: EliminarTipoPlatoComponent;
  let fixture: ComponentFixture<EliminarTipoPlatoComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EliminarTipoPlatoComponent]
    });
    fixture = TestBed.createComponent(EliminarTipoPlatoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
