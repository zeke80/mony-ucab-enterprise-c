import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  constructor( public router: Router ) { }

  ngOnInit() {
  }

  ingresar( f: NgForm ) {
    console.log(f.value.user);
    this.router.navigate(['/tabs/cuenta'])
  }

}
