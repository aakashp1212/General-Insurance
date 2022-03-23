import { TestBed } from '@angular/core/testing';

import { ClaimreasonsService } from './claimreasons.service';

describe('ClaimreasonsService', () => {
  let service: ClaimreasonsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ClaimreasonsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
