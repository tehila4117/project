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
  constructor(private dbSevise:DbService) { }

  ngOnInit(): void {
    

    this.signUpForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.pattern("^[0-9A-Za-zא-ת]*$"),, Validators.maxLength(8)])),
       
        email: new FormControl(''),
        UserType: new FormControl(''),
        password: new FormControl(''),
        InstitutionCode: new FormControl(''),
    


      }
    )

  }
 doSignUp(){
   console.log(this.signUpForm);
   const user:User= {
     userName:this.signUpForm.controls.userName.value,
     UserType:this.signUpForm.controls.UserType.value,
     password:this.signUpForm.controls.password.value
     InstitutionCode:this.signUpForm.controls.InstitutionCode.value
    }
    console.log(user);
    this.d
   }
   
 }

  //   <!-- שם משפחה -->
  //   <!-- גיל  -->
  //   <!-- תאריך לידה -->
  //   <!--טלפון -->
  //   <!-- מייל -->
  //   <!-- תז -->

  //   <!-- שם משתמש לאתר -->
  //   <!--סיסמא -->
  //   <!--אימות סיסמא -->
  //   <!-- אישור תנאי השימוש -->
  // 
}
