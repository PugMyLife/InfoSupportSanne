import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Upload } from './upload.model';

@Injectable()
export class UploadService{
    readonly baseURL = 'https://localhost:44357/api/CursusInstanties';
    
    constructor(private http: HttpClient){}


}
