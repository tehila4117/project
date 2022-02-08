import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { DbService } from 'src/app/server/db.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {


  users: User[] = [];

  constructor(private dbService: DbService) { 

  }

  ngOnInit(): void {

  }


  getUserDetails(){
   this.dbService.getUserDetails().subscribe(res=>{
      console.log(res);
      this.users = res;
    })
  }
}
