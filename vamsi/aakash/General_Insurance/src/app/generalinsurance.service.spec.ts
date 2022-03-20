import { TestBed } from '@angular/core/testing';

import { GeneralinsuranceService } from './generalinsurance.service';

describe('GeneralinsuranceService', () => {
  let service: GeneralinsuranceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GeneralinsuranceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
