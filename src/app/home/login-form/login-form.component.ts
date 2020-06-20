import { Component, OnInit } from '@angular/core';
import { LoginService } from './services/login.service';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  user: String;
  contra :String;

  constructor(public service: LoginService, public router: Router) { }

  ngOnInit(): void {
  }

  ingresarPersona(){
    this.service.loginPersona(this.user,this.contra).subscribe((data: any) => {
      this.router.navigate(['/dashboard'])
    });
  }

  ingresarComercio(){
    this.service.loginComercio(this.user,this.contra).subscribe((data: any) => {
      this.router.navigate(['/dashboard'])
    });
  }
}
