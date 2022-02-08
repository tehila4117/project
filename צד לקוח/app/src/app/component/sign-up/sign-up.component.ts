import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  signUpForm: any;
  constructor() { }

  ngOnInit(): void {

    this.signUpForm = new FormGroup(
      {
        userName: new FormControl('', Validators.compose([Validators.required, Validators.pattern("^[0-9A-Za-zא-ת]*$"),, Validators.maxLength(8)])),
       
        email: new FormControl(''),
        UserType: new FormControl(''),
        password: new FormControl(''),
        InstitutionCode: new FormControl(''),
        confirmPassword: new FormControl(''),
        agree: new FormControl(''),


      }
    )

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
