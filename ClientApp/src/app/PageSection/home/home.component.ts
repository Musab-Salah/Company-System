import { Component, OnInit } from '@angular/core';
import { PageSectionBo } from '../../models/PageSectionBo.model';
import { PageSectionService } from '../../services/pagesection.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  datalist: PageSectionBo[] = [];
  isEmptyList: boolean = false;
  private confirmmassage = "Are you sure to delete ?";
  constructor(private hdata: PageSectionService, private router: Router) { }
  ngOnInit(): void {
    this.GetallPageSection();
  }
  GetallPageSection(){
    this.hdata.getalldata().subscribe(
      result => {
        this.datalist = result;
        this.isEmptyList = this.datalist.length == 0;
      }
    );
  }
  deletepg(id: string) {
    this.hdata.deletePS(id)
      .subscribe(
        response => {
        }
      );
  }
  confirmAction(id: string) {
    let confirmAction = confirm(this.confirmmassage);
    if (confirmAction) {
      this.deletepg(id);
      location.reload();
    } else {
    }
  }
}
