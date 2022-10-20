import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { EditComponent } from './PageSection/update/update.component';
import { HomeComponent } from './PageSection/home/home.component';
import { CreateComponent } from './PageSection/create/create.component';
import { CreateDepartmentComponent } from './Department/create-department/create-department.component';
import { UpdateDepartmentComponent } from './Department/update-department/update-department.component';
import { HomeDepartmentComponent } from './Department/home-department/home-department.component';
import { CreateEmployeeComponent } from './Employee/create-employee/create-employee.component';
import { HomeEmployeeComponent } from './Employee/home-employee/home-employee.component';
import { UpdateEmployeeComponent } from './Employee/update-employee/update-employee.component';
import { CreateEmployeeDetailsComponent } from './Employee/EmployeeDetails/create-employee-details/create-employee-details.component';
import { UpdateEmployeeDetailsComponent } from './Employee/EmployeeDetails/update-employee-details/update-employee-details.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CreateComponent,
    EditComponent,
    CreateDepartmentComponent,
    UpdateDepartmentComponent,
    HomeDepartmentComponent,
    CreateEmployeeComponent,
    HomeEmployeeComponent,
    UpdateEmployeeComponent,
    CreateEmployeeDetailsComponent,
    UpdateEmployeeDetailsComponent, 
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
