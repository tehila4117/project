import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { User } from 'src/app/models/user';
import { DbService } from 'src/app/server/db.service';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})
export class SignInComponent implements OnInit {
  signInForm: any;
  constructor(private dbServise: DbService) { }

  ngOnInit(): void {

    this.signInForm = new FormGroup(
      {
        UserName: this.signInForm.controls.userName.value,
        Password: this.signInForm.controls.password.value


      }
    )

  }
  doSignIn() {

    const user: any = {
      UserName: this.signInForm.controls.userName.value,
      Password: this.signInForm.controls.password.value,

    }
    console.log(user);




    this.dbServise.doSignIn(user).subscribe(res => {
      console.log(res)
      if (res == null)
        alert("שגיאת שרת אין אפשרות להוסיף משתמשים חדשים נסה אחר")
      else
        alert("נרשמתה בהצלחה")
    })
  }


}