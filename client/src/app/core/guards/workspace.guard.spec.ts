import { TestBed, async, inject } from '@angular/core/testing';

import { WorkspaceGuard } from './workspace.guard';

describe('WorkspaceGuard', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WorkspaceGuard]
    });
  });

  it('should ...', inject([WorkspaceGuard], (guard: WorkspaceGuard) => {
    expect(guard).toBeTruthy();
  }));
});
