import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GetdatalistService } from '../services/pagesection.service';
import { PageSectionBo } from '../models/PageSectionBo.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  bo: PageSectionBo = {
    title: '',
    description: '',
    orderNumber: 0,
    id:''
  }
  constructor(private route:ActivatedRoute, private getps:GetdatalistService ,private router:Router) { }

  ngOnInit(): void {
this.route.paramMap.subscribe({
  next: (parm)=>{
    const id =parm.get('id');
    
    if(id){
    this.getps.getPS(id)
    .subscribe({
      next : (response)=>{
          this.bo = response;
      }
    });  
    }
  }
});
  }
  Update(){
    this.getps.UpdatePS( this.bo.id,this.bo)
    .subscribe({
      next : (response)=>{
        this.router.navigate(['Home'])
    }
    });
  }
}
