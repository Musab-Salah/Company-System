import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeBo } from 'src/app/models/EmployeeBo.model';
import { EmployeeService } from 'src/app/services/employee/employee.service';

@Component({
  selector: 'app-update-employee',
  templateUrl: './update-employee.component.html',
  styleUrls: ['./update-employee.component.css']
})
export class UpdateEmployeeComponent implements OnInit {
  bo: EmployeeBo = {
    id: '',
    sn: '',
    fullName: '',
    email: '',
    password: '',
    managerid: '1'
  }
  constructor(private route: ActivatedRoute, private getps: EmployeeService, private router: Router) { }
  ngOnInit(): void {
   this.GetId();
  }
  GetId(){
    this.route.paramMap.subscribe({
      next: (parm) => {
        const id = parm.get('id');
        if (id) {
          this.getps.getEmployee(id)
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
    this.getps.UpdateEmployee(this.bo.id, this.bo)
      .subscribe({
        next: (response) => {
          this.router.navigate(['HomeEmployee'])
        }
      });
  }
}
