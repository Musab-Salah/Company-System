import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeBo } from 'src/app/models/EmployeeBo.model';
import { EmployeeService } from 'src/app/services/employee/employee.service';
@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})

export class CreateEmployeeComponent implements OnInit {
  bo: EmployeeBo = {
    id : '0',
    sn: '',
    fullName:'',
    email: '',
    password: '',
    managerid: '1'
  }
  boe: EmployeeBo = {
    id: '',
    sn: '',
    fullName: '',
    email: '',
    password: '',
    managerid: '0'
  }
  selectedOption: string='';
  constructor(private route: ActivatedRoute,private hdata: EmployeeService, private router: Router) { }
  ngOnInit(): void {
  }
  create() {
    
    this.hdata.addEmployee(this.bo)
      .subscribe(
        response => {
          this.boe= response;
        });
  }
 
}
