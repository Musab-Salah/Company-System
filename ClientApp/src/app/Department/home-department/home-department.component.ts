import { Component, OnInit } from '@angular/core';
import { DepartmentBo } from '../../models/DepartmentBo.model';
import { DepartmentService } from '../../services/department.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-home-department',
  templateUrl: './home-department.component.html',
  styleUrls: ['./home-department.component.css']
})
export class HomeDepartmentComponent implements OnInit {
  datalist:  DepartmentBo[] = [];
  isEmptyList: boolean = false;
  private confirmmassage = "Are you sure to delete ?";
  constructor(private hdata: DepartmentService, private router: Router) { }
  ngOnInit(): void {
    this.GetallDepartment();
  }
  GetallDepartment(){
    this.hdata.getallDepartment().subscribe(
      result => {
        this.datalist = result;
        this.isEmptyList = this.datalist.length == 0;
      }
    );
  }
  deleteDepartment(id: string) {
    this.hdata.deleteDepartment(id)
      .subscribe(
        response => {
        }
      );
  }
  confirmAction(id: string) {
    let confirmAction = confirm(this.confirmmassage);
    if (confirmAction) {
      this.deleteDepartment(id);
      location.reload();
    } else {
    }
  }

}
