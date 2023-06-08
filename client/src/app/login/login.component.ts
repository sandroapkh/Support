import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { User } from '../_models/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{
  model: any = {};
  currentUser$: Observable<User | null> = of(null); 
  constructor(private accountService: AccountService, private router: Router){}
  ngOnInit(): void {
  }

login(): void{
  this.accountService.login(this.model).subscribe({
    next: response => {
      console.log(response)
     
      // this.router.navigateByUrl('/home')
    },
    error: error => console.log(error)
  })
}

logout(){
  this.accountService.logout();
  
}
}
