import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import {CursusService} from './cursus.service'


@Component({
  selector: 'cursusoverzicht',
  templateUrl: './cursus.component.html',
  styleUrls: ['./cursus.component.css']
})
export class CursusComponent {

  constructor(public cursusService: CursusService){}
  ngOnInit(): void{
    this.cursusService.fetchCursus();
  }     
}
