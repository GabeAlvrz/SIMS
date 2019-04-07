import { Component, OnInit } from '@angular/core';
import { UserService } from '../../_services/user.service';
import { AlertifyService } from '../../_services/alertify.service';
import { User } from '../../_models/user';
import { ActivatedRoute } from '@angular/router';
import { Pagination, PaginatedResult } from 'src/app/_models/pagination';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
  users: User[];
  // user: User = JSON.parse(localStorage.getItem('user'));
  roleList = [{value: 'Student', display: 'Students'}, {value: 'Faculty', display: 'Faculty'}];
  searchByOptions = [{value: 'firstName', display: 'First Name'}, {value: 'lastName', display: 'Last Name'}];
  orderByOptions = [{value: 'Last Name: A-Z', display: 'Last Name: A-Z'}, {value: 'Last Name: Z-A', display: 'Last Name: Z-A'},
                    {value: 'First Name: A-Z', display: 'First Name: A-Z'}, {value: 'First Name: Z-A', display: 'First Name: Z-A'}];
  userParams: any = {};
  pagination: Pagination;

  constructor(private userService: UserService, private alertify: AlertifyService, private router: ActivatedRoute) { }

  ngOnInit() {
    this.router.data.subscribe(data => {
      this.users = data['users'].result;
      this.pagination = data['users'].pagination;
    });

    // this.userParams.gender = this.user.gender === 'female' ? 'male' : 'female';
    // this.userParams.gender = 'male';
    // this.userParams.minAge = 18;
    // this.userParams.maxAge = 99;
    // this.userParams.orderBy = 'lastActive';
    this.userParams.role = 'Student';
    this.userParams.searchBy = '';
    this.userParams.searchByInput = '';
    this.userParams.orderBy = '';
  }

  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadUsers();
  }

  // resetFilters() {
    // before
    // this.userParams.gender = this.user.gender === 'female' ? 'male' : 'female';
    // this.userParams.gender = 'male';
    // this.userParams.minAge = 18;
    // this.userParams.maxAge = 99;
    // after
    // this.userParams.role = 'Student';
    // this.loadUsers();
  // }

  handleInput(event: KeyboardEvent) {
    if (this.userParams.searchBy !== '') {
      this.loadUsers();
    }
  }

  loadUsers() {
    this.userService.getUsers(this.pagination.currentPage, this.pagination.itemsPerPage, this.userParams)
    .subscribe((res: PaginatedResult<User[]>) => {
      this.users = res.result;
      this.pagination = res.pagination;
    }, error => {
      this.alertify.error(error);
    });
  }

}
