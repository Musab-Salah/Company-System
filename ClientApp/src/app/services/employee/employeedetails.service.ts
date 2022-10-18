import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EmployeeDetailsBo } from 'src/app/models/EmployeeDetailsBo.model';
@Injectable({
  providedIn: 'root'
})
export class EmployeeDetailsService {
  readonly url='http://localhost:5115/EmployeeDetails'
  constructor(private http: HttpClient) { }
  
  public getallEmployeeDetails() {
    let mydata = this.http.get<EmployeeDetailsBo[]>(this.url);
    return mydata;
  }
  addEmployeeDetails(bo: EmployeeDetailsBo)  {
    // const header = new HttpHeaders()
    // .set('Content-type', 'application/json');
    // const body = JSON.stringify(bo);
   return this.http.post<EmployeeDetailsBo>(this.url +'/Create', bo)
  }
  deleteEmployeeDetails(id: string) {
    return this.http.delete<EmployeeDetailsBo>(this.url + '/Delete' + '/' + id);
  }
  getEmployeeDetails(id: string) {
    return this.http.get<EmployeeDetailsBo>(this.url + '/Get' + '/' + id);
  }
  UpdateEmployeeDetails(id: string, bo: EmployeeDetailsBo) {
    return this.http.put<EmployeeDetailsBo>(this.url + '/Update' + '/' + id, bo);
  } 
}
