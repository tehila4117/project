import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../models/user';


@Injectable({
  providedIn: 'root'
})
export class DbService {

  constructor(private httpClient:HttpClient) { }


  getUserDetails():Observable<User[]>{
    return this.httpClient.get<User[]>('http://localhost:53636/api/UsersTable/GetallUsers');
  }


  getUserSignUp(){

  }
}
