import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PageSectionBo } from 'src/app/models/PageSectionBo.model';
import { PageSectionService } from 'src/app/services/pagesection.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-edit',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class EditComponent implements OnInit {
  bo: PageSectionBo = {
    title: '',
    description: '',
    orderNumber: 0,
    id: ''
  }
  constructor(private route: ActivatedRoute, private getps: PageSectionService, private router: Router) { }
  ngOnInit(): void {
   this.GetId();
  }
  GetId(){
    this.route.paramMap.subscribe({
      next: (parm) => {
        const id = parm.get('id');
        if (id) {
          this.getps.getPS(id)
            .subscribe({
              next: (response) => {
                this.bo = response;
              }
            });
        }
      }
    });
  }
  Update() {
    this.getps.UpdatePS(this.bo.id, this.bo)
      .subscribe({
        next: (response) => {
          this.router.navigate(['Home'])
        }
      });
  }
}
