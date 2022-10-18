import { Component, OnInit } from '@angular/core';
import { DepartmentBo } from 'src/app/models/DepartmentBo.model';
import { DepartmentService } from 'src/app/services/department.service';
import { Router } from '@angular/router';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-update-department',
  templateUrl: './update-department.component.html',
  styleUrls: ['./update-department.component.css']
})
export class UpdateDepartmentComponent implements OnInit {

  bo: DepartmentBo = {
    name: '',
    description: '',
    prefix: '',
    id: ''
  }
  constructor(private route: ActivatedRoute, private getps: DepartmentService, private router: Router) { }
  ngOnInit(): void {
   this.GetId();
  }
  GetId(){
    this.route.paramMap.subscribe({
      next: (parm) => {
        const id = parm.get('id');
        if (id) {
          this.getps.getDepartment(id)
            .subscribe({
              next: (response) => {
                this.bo = response;
              }
            });
        }
      }
    });
  }
  Update() {
    this.getps.UpdateDepartment(this.bo.id, this.bo)
      .subscribe({
        next: (response) => {
          this.router.navigate(['HomeDepartment'])
        }
      });
  }

}
