import { TestBed } from '@angular/core/testing';

import { SocketsService } from './sockets.service';

describe('SocketsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SocketsService = TestBed.get(SocketsService);
    expect(service).toBeTruthy();
  });
});
