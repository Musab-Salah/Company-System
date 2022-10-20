import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EmployeeBo } from '../../models/EmployeeBo.model';
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  readonly url='http://localhost:5115/Employee'
  constructor(private http: HttpClient) { }

  public getallEmployee() {
   return this.http.get<EmployeeBo[]>(this.url);
  }
  addEmployee(bo: EmployeeBo)  {
   return this.http.post<EmployeeBo>(this.url +'/Create', bo)
  }
  deleteEmployee(id: string) {
    return this.http.delete<EmployeeBo>(this.url + '/Delete' + '/' + id);
  }
  getEmployee(id: string) {
    return this.http.get<EmployeeBo>(this.url + '/Get' + '/' + id);
  }
  UpdateEmployee(id: string, bo: EmployeeBo) {
    return this.http.put<EmployeeBo>(this.url + '/Update' + '/' + id, bo);
  }
}
