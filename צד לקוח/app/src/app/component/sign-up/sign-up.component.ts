import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/models/user';
import { DbService } from 'src/app/server/db.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;
  constructor(private dbServise: DbService) { }

  ngOnInit(): void {


    this.signUpForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.pattern("^[0-9A-Za-zא-ת]*$"), , Validators.maxLength(8)])),
        email: new FormControl(''),
        UserType: new FormControl(''),
        password: new FormControl(''),
        InstitutionCode: new FormControl(''),
      }
    )

  }
  doSignUp() {

    const user: User = {
      UserName: this.signUpForm.controls.userName.value,
      Password: this.signUpForm.controls.password.value,
      Miles: this.signUpForm.controls.email.value,
      UserType: parseInt( this.signUpForm.controls.UserType.value),
      InstitutionCode: parseInt(this.signUpForm.controls.InstitutionCode.value)
    }
    console.log(user);
 



    this.dbServise.doSignUp(user).subscribe(res =>{
      console.log(res)
      if(res==null)
      alert("שגיאת שרת אין אפשרות להוסיף משתמשים חדשים נסה אחר")
      else
      alert("נרשמתה בהצלחה")
    })
  }

}

  