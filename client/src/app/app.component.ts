import { HttpClient } from '@angular/common/http';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, OnDestroy{
  
  title = 'My-App'
  users: any;

  
  constructor(private http: HttpClient, public accountService: AccountService) {}
  

  ngOnInit(): void {
     this.getUser();
     this.setCurrentUser();
  }
 


  setCurrentUser(){
    const userString = localStorage.getItem('user');
    if(!userString) return;
    const user: User = JSON.parse(userString);
    this.accountService.setCurrentUser(user);
  }

  getUser(){
    this.http.get("https://localhost:7257/api/users").subscribe({
      next: response => this.users = response,
      error: error => console.log(error),
      complete: () => console.log("Request has Completed")
    })
  }
  ngOnDestroy(): void {
    
  }
}
