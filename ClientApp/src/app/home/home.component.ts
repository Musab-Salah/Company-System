import { Component, OnInit } from '@angular/core';
import { PageSectionBo } from '../models/PageSectionBo.model';
import { GetdatalistService } from '../services/pagesection.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
 datalist :PageSectionBo[]=[];
 isEmptyList: boolean=false ;
  constructor(private hdata:GetdatalistService, private router:Router ) { }

  
  
  ngOnInit(): void {
    
    this.hdata.getalldata().subscribe(
      result=>{
        this.datalist=result;
        this.isEmptyList = this.datalist.length == 0;
      }
    );
    
  }
  
  deletepg(id:string){
  this.hdata.deletePS(id)
  .subscribe(
    response =>{
      location.reload();
    }
  );
  }

  confirmAction(id:string) {
    let confirmAction = confirm("Are you sure to delete ?");
    if (confirmAction) {
      this.deletepg(id);
    } else {
    }
  }
}
