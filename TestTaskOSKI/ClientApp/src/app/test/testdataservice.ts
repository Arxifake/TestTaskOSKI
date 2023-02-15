import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable()
export class TestDataService {
  private url = 'test/';
  constructor(private http: HttpClient) {
  }
  GetTest(id:any): Observable<any> {
    return this.http.get(this.url+'GetTest/'+id)
  }
}
