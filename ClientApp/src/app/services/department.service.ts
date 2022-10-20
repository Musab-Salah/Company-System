import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { DepartmentBo } from '../models/DepartmentBo.model';
@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  readonly url='http://localhost:5115/Department';
  constructor(private http: HttpClient) { }
  
  public getallDepartment() {
    return this.http.get<DepartmentBo[]>( this.url );  
  }
  addDepartment(bo: DepartmentBo) {
    return this.http.post<DepartmentBo>(this.url + '/Create', bo)
  }
  deleteDepartment(id: string) {
    return this.http.delete<DepartmentBo>(this.url +'/Delete' + '/' + id);
  }
  getDepartment(id: string) {
    return this.http.get<DepartmentBo>(this.url + '/Get' + '/' + id);
  }
  UpdateDepartment(id: string, bo: DepartmentBo) {
    return this.http.put<DepartmentBo>(this.url + '/Update' + '/' + id, bo);
  }
}
