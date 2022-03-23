import { TestBed } from '@angular/core/testing';

import { CalcfourinsuranceService } from './calcfourinsurance.service';

describe('CalcfourinsuranceService', () => {
  let service: CalcfourinsuranceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalcfourinsuranceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
