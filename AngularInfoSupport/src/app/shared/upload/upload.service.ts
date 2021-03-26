import {Injectable} from '@angular/core';
import {HttpClient, HttpEventType, HttpHeaders, HttpParams, HttpRequest, } from '@angular/common/http'
import { Observable } from 'rxjs';


@Injectable()
export class UploadService{
    constructor(private http: HttpClient){}
    headers: { 
      'Accept': 'application/json',
      'Content-Type': 'application/json' 
  }

    posturl: string =`https://localhost:44357/api/ReceiveJSON`
    json;
    fileData;
    sendFile(){
      let stringFileData = String(this.fileData)
      let stringifiedFileData = JSON.stringify({content: stringFileData});
      let headersoptions = new HttpHeaders({'Content-Type': 'text/json'});
      let options = {headers: headersoptions}
      console.log(this.fileData);
        return this.http.post(this.posturl, stringifiedFileData, options).subscribe(result => {
        alert(result);
        }, error => console.error(error));
    }  

  
    readThis(inputValue: any) {
      var file:File = inputValue.files[0]; 
      var myReader:FileReader = new FileReader();
  
      myReader.onloadend = (e) => {
       this.fileData = myReader.result
      }
  
      myReader.readAsText(file);
    }
}
  
