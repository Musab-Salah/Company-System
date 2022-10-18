import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeBo } from 'src/app/models/EmployeeBo.model';
import { EmployeeService } from 'src/app/services/employee/employee.service';
import { DepartmentService } from 'src/app/services/department.service';
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
  selectedOption: string='';
  constructor(private employeeservice: EmployeeService, private router: Router,private departmentService: DepartmentService) { }
  ngOnInit(): void {
  }

  next() {
    this.employeeservice.addEmployee(this.bo)
      .subscribe(
        response => {
          this.router.navigate(['CreateEmployeeDetails'])
        });
  }
}
