import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DepartmentBo } from 'src/app/models/DepartmentBo.model';
import { EmployeeBo } from 'src/app/models/EmployeeBo.model';
import { EmployeeDetailsBo } from 'src/app/models/EmployeeDetailsBo.model';
import { DepartmentService } from 'src/app/services/department.service';
import { EmployeeService } from 'src/app/services/employee/employee.service';
import { EmployeeDetailsService } from 'src/app/services/employee/employeedetails.service';
@Component({
  selector: 'app-create-employee-details',
  templateUrl: './create-employee-details.component.html',
  styleUrls: ['./create-employee-details.component.css']
})
export class CreateEmployeeDetailsComponent implements OnInit {
  boe: EmployeeBo = {
    id: '',
    sn: '',
    fullName: '',
    email: '',
    password: '',
    managerid: '1'
  }
  bo: EmployeeDetailsBo = {
    id: '',
    phonenumber: 0,
    gender: 'Male',
    startdate: new Date("Fri Dec 08 2019 07:44:57"),
    departmentid: '1',
    employeeid: '1'
  }
  datalist:  DepartmentBo[] = [];
  constructor( private getps: EmployeeService,private route: ActivatedRoute,private employeedetailsservice: EmployeeDetailsService, private router: Router,private departmentService: DepartmentService) { }
  ngOnInit(): void {
    this.getallDepartment();
    this.GetId();
  }
  getallDepartment(){
    this.departmentService.getallDepartment().subscribe(
      result => {
        this.datalist = result;
      }
    );
  }
  GetId(){
    this.route.paramMap.subscribe({
      next: (parm) => {
        const id = parm.get('id');
        if (id) {
          this.getps.getEmployee(id)
            .subscribe({
              next: (response) => {
                this.boe = response;
              }
            });
        }
      }
    });
  }
  onSelectedDepartment(i:any ){
    this.bo.departmentid=this.datalist[i].id;
}
onSelectedGender(i:any){
this.bo.gender=i;
}
  create() {
    this.bo.employeeid=this.boe.id;
    this.employeedetailsservice.addEmployeeDetails(this.bo)
      .subscribe(
        response => {
          this.router.navigate(['HomeEmployee'])
        });
  }
}
