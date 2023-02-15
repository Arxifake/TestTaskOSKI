import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthGuard } from "../AuthGuard/AuthGuard";
import { NewUser } from '../DTO/NewUser';
import { LoginDataService } from './logindataservice';

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html',
  providers: [LoginDataService, AuthGuard]
})
export class LoginComponent implements OnInit {
  public loginForm: FormGroup;
  private _returnUrl: '';
  constructor(private logindataservice: LoginDataService, private _router: Router, private _route: ActivatedRoute, private authGuard: AuthGuard) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      firstname: new FormControl("", [Validators.required]),
      secondname: new FormControl("", [Validators.required])
    })
    this._returnUrl = this._route.snapshot.queryParams['returnUrl'] || '/';

  }
  public loginUser = (loginFormValue: any) => {
    const login = { ...loginFormValue };
    const userForAuth: NewUser = {
      firstName: login.firstname,
      secondName: login.secondname
    }
    this.logindataservice.Login(userForAuth).subscribe((res) => {
      sessionStorage.setItem('userId', res.toString())
      this._router.navigate([this._returnUrl]);
    })
  }
}
