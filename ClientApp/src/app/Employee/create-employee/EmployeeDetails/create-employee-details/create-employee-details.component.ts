import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DepartmentBo } from 'src/app/models/DepartmentBo.model';
import { EmployeeDetailsBo } from 'src/app/models/EmployeeDetailsBo.model';
import { DepartmentService } from 'src/app/services/department.service';
import { EmployeeDetailsService } from 'src/app/services/employee/employeedetails.service';
@Component({
  selector: 'app-create-employee-details',
  templateUrl: './create-employee-details.component.html',
  styleUrls: ['./create-employee-details.component.css']
})
export class CreateEmployeeDetailsComponent implements OnInit {
  bo: EmployeeDetailsBo = {
    id: '',
    phonenumber: 0,
    gender: '',
    startdate: '',
    departmentid: 0
  }
  printedOption: string='';
  datalist:  DepartmentBo[] = [];
  selectedOption: string='';
  constructor(private employeedetailsservice: EmployeeDetailsService, private router: Router,private departmentService: DepartmentService) { }
  ngOnInit(): void {
    this.getallDepartment();
  }
  getallDepartment(){
    this.departmentService.getallDepartment().subscribe(
      result => {
        this.datalist = result;
      }
    );
  }
  create() {
    this.employeedetailsservice.addEmployeeDetails(this.bo)
      .subscribe(
        response => {
          this.router.navigate(['HomeEmployee'])
        });
  }
  options = [
    { name: "Male", value: 1 },
    { name: "Famel", value: 2 }
  ]
  
}

