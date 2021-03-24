import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Observable, of } from 'rxjs';
import { UploadService } from './upload.service';
import {catchError, map} from 'rxjs/operators';
import {HttpClient, HttpErrorResponse, HttpEventType} from '@angular/common/http';
@Component({
  selector: 'upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadComponent{
  fileName = '';
    constructor(public uploadService: UploadService, private http: HttpClient){
      
    }
    ngOnInit(): void{
    }     
  sendData(){
    this.uploadService.sendFile();
  }
  changeListener($event) : void {
    this.uploadService.readThis($event.target);
  }

}

  
