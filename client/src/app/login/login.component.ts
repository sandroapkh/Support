import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{
  model: any = {};
  loggedIn = false;
  constructor(private accountService: AccountService, private router: Router){}
  ngOnInit(): void {
  }

login(): void{
  this.accountService.login(this.model).subscribe({
    next: response => {
      console.log(response)
      this.loggedIn = true;
      this.router.navigateByUrl('/home')
    },
    error: error => console.log(error)
  })
}

logout(){
  this.loggedIn = false;
}
}
