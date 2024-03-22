import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IncorporateMovieComponent } from './incorporate-movie.component';

describe('IncorporateMovieComponent', () => {
  let component: IncorporateMovieComponent;
  let fixture: ComponentFixture<IncorporateMovieComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [IncorporateMovieComponent]
    });
    fixture = TestBed.createComponent(IncorporateMovieComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
