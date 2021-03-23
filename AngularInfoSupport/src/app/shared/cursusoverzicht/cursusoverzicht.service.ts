import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { CursusOverzicht } from './cursusoverzicht.model';

@Injectable()
export class CursusService{
    constructor(private http: HttpClient){}
    formData: CursusOverzicht = new CursusOverzicht();
    list: CursusOverzicht[];
    readonly baseURL = 'https://localhost:44357/api/overzicht';

    fetchCursus(){
        return this.http.get(this.baseURL)
        .toPromise()
        .then(res => this.list = res as CursusOverzicht[]);
        console.log('het werkt');
    }
}

