import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { PageSectionBo } from '../models/PageSectionBo.model';
@Injectable({
  providedIn: 'root'
})
export class PageSectionService {
  readonly url='http://localhost:5115/PageSection'
  constructor(private http: HttpClient) { }
  
  public getalldata() {
   return this.http.get<PageSectionBo[]>(this.url);
  }
  addPS(bo: PageSectionBo) {
    return this.http.post<PageSectionBo>(this.url +'/Create' , bo)
  }
  deletePS(id: string) {
    return this.http.delete<PageSectionBo>(this.url + '/Delete' + '/' + id);
  }
  getPS(id: string) {
    return this.http.get<PageSectionBo>(this.url + '/Get' + '/' + id);
  }
  UpdatePS(id: string, bo: PageSectionBo) {
    return this.http.put<PageSectionBo>(this.url + '/Update' + '/' + id, bo);
  }
}
