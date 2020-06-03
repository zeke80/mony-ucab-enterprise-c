import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgForm } from '@angular/forms';
@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  constructor(public router: Router) { }

  ngOnInit() {
  }

  ingresar( f: NgForm ) {
    console.log(f.value.user);
    console.log(f.value.password);

    this.router.navigate(['/tabs/cuenta']);
  }

}
