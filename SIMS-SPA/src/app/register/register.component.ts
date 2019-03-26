import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { BsDatepickerConfig } from 'ngx-bootstrap';
import { User } from '../_models/user';
import { Router } from '@angular/router';
import { AdminService } from '../_services/admin.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  user: User;
  roles: any[];
  registerForm: FormGroup;
  bsConfig: Partial<BsDatepickerConfig>;

  constructor(private adminService: AdminService, private authService: AuthService, private router: Router,
    private alertify: AlertifyService, private fb: FormBuilder) { }

  ngOnInit() {
    this.bsConfig = {
      containerClass: 'theme-orange'
    },
    this.createRegisterForm();
  }

  createRegisterForm() {
    this.registerForm = this.fb.group({
      userName: ['', Validators.required],
      firstName: ['', Validators.required],
      middleName: [''],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      dateOfBirth: [null, Validators.required],
      initialRole: ['', Validators.required],
      currentAcademicLevel: [''],
      degreeProgram: [''],
      currentProgram: [''],
      bachelorsStartDate: [''],
      bachelorsMentor: [''],
      bachelorsProjectAdvisor: [''],
      bachelorsThesisAdvisor: [''],
      bachelorsProjectTitle: [''],
      bachelorsThesisTitle: [''],
      bachelorsGradDate: [''],
      mastersStartDate: [''],
      mastersFocus: [''],
      mastersProjectAdvisor: [''],
      mastersThesisAdvisor: [''],
      mastersCommitteeFormDate: [''],
      mastersDefenseDate: [''],
      mastersProjectTitle: [''],
      mastersThesisTitle: [''],
      mastersGradDate: [''],
      doctoralCandidate: [''],
      doctorateStartDate: [''],
      dateAcceptedForCandidacy: [''],
      doctorateAdvisor: [''],
      dissertationDefenseDate: [''],
      dissertationTitle: [''],
      doctorateGradDate: [''],
      password: ['', [Validators.required, Validators.minLength(8), Validators.maxLength(16)]],
      confirmPassword: ['', Validators.required]
    }, {validator: this.passwordMatchValidator});
  }

  passwordMatchValidator(g: FormGroup) {
    return g.get('password').value === g.get('confirmPassword').value ? null : {'mismatch': true};
  }

  register() {
    if (this.registerForm.valid) {
      this.user = Object.assign({}, this.registerForm.value);
      this.authService.register(this.user).subscribe(() => {
        this.alertify.success('Registration complete');
      }, error => {
        this.alertify.error(error);
      }, () => {
        const rolesToUpdate = {
          roleNames: [this.registerForm.value.initialRole]
        };
        this.adminService.updateUserRoles(this.user, rolesToUpdate).subscribe(() => {});
        this.router.navigate(['/mainpage']);
        // this.authService.login(this.user).subscribe(() => {
        //   this.router.navigate(['/members']);
        // });
      });
    }
  }

  cancel() {
    this.cancelRegister.emit(false);
    this.router.navigate(['/mainpage']);
    this.alertify.message('Cancelled');
  }

}
