import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DepartmentBo } from 'src/app/models/DepartmentBo.model';
import { DepartmentService } from 'src/app/services/department.service';
@Component({
  selector: 'app-create-department',
  templateUrl: './create-department.component.html',
  styleUrls: ['./create-department.component.css']
})
export class CreateDepartmentComponent implements OnInit {
  bo: DepartmentBo = {
    name : '',
    description: '',
    prefix:'',
    id: '0'
  }
  constructor(private hdata: DepartmentService, private router: Router) { }
  ngOnInit(): void {
  }
  create() {
    this.hdata.addDepartment(this.bo)
      .subscribe(
        response => {
          this.router.navigate(['HomeDepartment'])
        });
  }

}
