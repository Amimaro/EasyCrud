import { TestBed, inject } from '@angular/core/testing';

import { ProgrammerService } from './programmer.service';

describe('ProgrammerService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProgrammerService]
    });
  });

  it('should be created', inject([ProgrammerService], (service: ProgrammerService) => {
    expect(service).toBeTruthy();
  }));
});
