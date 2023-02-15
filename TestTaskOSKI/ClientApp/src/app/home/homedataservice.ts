import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class HomeDataService {
  private url = 'home/';
  constructor(private http: HttpClient) {
  }
  GetTests(userId: any): Observable<any> {
    return this.http.get(this.url + 'GetTests/' + userId)
  }
}
