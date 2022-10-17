import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeBo } from 'src/app/models/EmployeeBo.model';
import { EmployeeService } from 'src/app/services/employee.service';
@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})
export class CreateEmployeeComponent implements OnInit {
  bo: EmployeeBo = {
    id: '',
   sn:'',
   fullname:'',
   email: '',
   password:'' ,
   managerid: 0
  }
  constructor(private hdata: EmployeeService, private router: Router) { }
  ngOnInit(): void {
  }
  create() {
    this.hdata.addEmployee(this.bo)
      .subscribe(
        response => {
          this.router.navigate(['HomeDepartment'])
        });
  }
}
