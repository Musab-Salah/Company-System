import { createComponent, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateComponent } from './PageSection/create/create.component';
import { EditComponent } from './PageSection/update/update.component';
import { HomeComponent } from './PageSection/home/home.component';
import { HomeDepartmentComponent } from './Department/home-department/home-department.component';
import { CreateDepartmentComponent } from './Department/create-department/create-department.component';
import { UpdateDepartmentComponent } from './Department/update-department/update-department.component';
import { CreateEmployeeComponent } from './Employee/create-employee/create-employee.component';
import { HomeEmployeeComponent } from './Employee/home-employee/home-employee.component';
import { UpdateEmployeeComponent } from './Employee/update-employee/update-employee.component';
import { CreateEmployeeDetailsComponent } from './Employee/EmployeeDetails/create-employee-details/create-employee-details.component';
const routes: Routes = [
  { path: 'Create', component: CreateComponent },
  { path: 'Home', component: HomeComponent },
  { path: 'edit/:id', component: EditComponent },
  { path: 'CreateDepartment', component: CreateDepartmentComponent },
  { path: 'HomeDepartment', component: HomeDepartmentComponent },
  { path: 'UpdateDepartment/:id', component: UpdateDepartmentComponent },
  { path: 'CreateEmployee', component: CreateEmployeeComponent },
  { path: 'HomeEmployee', component: HomeEmployeeComponent },
  { path: 'UpdateEmployee/:id', component: UpdateEmployeeComponent },
  { path: 'CreateEmployeeDetails/:id', component: CreateEmployeeDetailsComponent },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
