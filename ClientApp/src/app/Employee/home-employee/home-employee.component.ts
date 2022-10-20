import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeBo } from 'src/app/models/EmployeeBo.model';
import { EmployeeService } from 'src/app/services/employee/employee.service';
@Component({
  selector: 'app-home-employee',
  templateUrl: './home-employee.component.html',
  styleUrls: ['./home-employee.component.css']
})
export class HomeEmployeeComponent implements OnInit {
  datalist:  EmployeeBo[] = [];
  isEmptyList: boolean = false;
  private confirmmassage = "Are you sure to delete ?";
  constructor(private hdata: EmployeeService, private router: Router) { }
  ngOnInit(): void {
    this.GetallEmployee();
  }
  GetallEmployee(){
    this.hdata.getallEmployee().subscribe(
      result => {
        this.datalist = result;
        this.isEmptyList = this.datalist.length == 0;
      }
    );
  }
  deleteEmployee(id: string) {
    this.hdata.deleteEmployee(id)
      .subscribe(
        response => {
        }
      );
  }
  confirmAction(id: string) {
    let confirmAction = confirm(this.confirmmassage);
    if (confirmAction) {
      this.deleteEmployee(id);
      location.reload();
    } else {
    }
  }

}
