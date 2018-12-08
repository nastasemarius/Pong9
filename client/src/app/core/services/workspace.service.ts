import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Workspace } from '../models/workspace';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WorkspaceService {
  private workspaceUrl = `${environment.apiUrl}/workSpace/create`;
  constructor(private HttpService: HttpClient) { }

  createWorkspace(workspace: Workspace): Observable<any> {
    return this.HttpService.post(this.workspaceUrl, workspace);
  }
}
