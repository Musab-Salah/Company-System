import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PageSectionBo } from '../models/PageSectionBo.model';
@Injectable({
  providedIn: 'root'
})
export class GetdatalistService {

  constructor(private http: HttpClient) { }

  public getalldata(){
    let mydata = this.http.get<PageSectionBo[]>("http://localhost:5115/PageSection");
    return mydata;
  }

  addPS(bo:PageSectionBo) {
    
    return this.http.post<PageSectionBo>("http://localhost:5115/PageSection/Create", bo)
  
  }

  deletePS(id:string){
    return this.http.delete<PageSectionBo>("http://localhost:5115/PageSection/Delete"+'/'+id);
  }

  getPS(id:string){
  return  this.http.get<PageSectionBo>("http://localhost:5115/PageSection/Get"+'/'+id);
  }

  UpdatePS(id:string,bo:PageSectionBo){
 return this.http.put<PageSectionBo>("http://localhost:5115/PageSection/Update"+'/'+id,bo);
  }

}
