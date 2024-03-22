import { TestBed } from '@angular/core/testing';

import { MyHttpInterceptor } from './http-interceptor.service';

describe('MyHttpInterceptor', () => {
  let service: MyHttpInterceptor;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyHttpInterceptor);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
