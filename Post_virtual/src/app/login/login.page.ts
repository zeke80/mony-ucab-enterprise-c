import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
import { LoginService } from '../servicios/login/login.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  constructor(public router: Router,
              public _loginServices: LoginService) { }

  ngOnInit() {
  }

  ingresar( f: NgForm ) {
    this._loginServices.verificarUsuario(f.value.user, f.value.password)
            .subscribe((data: any) => {
              console.log(data);
              this.router.navigate(['/tabs/cuenta']);

            });

  }

}
