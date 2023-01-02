import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SharedService {
  readonly APIUrl = 'https://localhost:44368';

  constructor(private http: HttpClient) {}

  getProjectList(): Observable<any> {
    return this.http.get<any>(this.APIUrl);
  }

  addProject(data: Date) {
    return this.http.post(this.APIUrl, data);
  }
}
