import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { PageSectionBo } from 'src/app/models/PageSectionBo.model';
import { PageSectionService } from 'src/app/services/pagesection.service';
@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  bo: PageSectionBo = {
    title: '',
    description: '',
    orderNumber: 0,
    id: '0'
  }
  constructor(private hdata: PageSectionService, private router: Router) { }
  ngOnInit(): void {
  }
  create() {
    this.hdata.addPS(this.bo)
      .subscribe(
        response => {
          this.router.navigate(['Home'])
        });
  }
}
