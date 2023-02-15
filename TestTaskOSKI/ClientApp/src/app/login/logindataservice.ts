import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { NewUser } from '../DTO/NewUser';

@Injectable()
export class LoginDataService {
  private url = 'login';
  constructor(private http: HttpClient) {
  }
  Login(body: NewUser)
  {
    return this.http.post(this.url, body);  
  }
}

