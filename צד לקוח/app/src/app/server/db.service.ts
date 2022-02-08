import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class DbService {

  constructor(private httpClient:HttpClient) { }
  getUserDetails(user){
    return this.httpClient.get<user>('http://localhost:53636/api/UsersTable/GetallUsers');
  }
  getUserSignUp(){
    
  }
}
