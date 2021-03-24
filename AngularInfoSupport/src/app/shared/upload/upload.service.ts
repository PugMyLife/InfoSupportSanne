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

    posturl: string = `https://localhost:44357/api/CursusDetails`;
    posturl2: string =`https://localhost:44357/api/ReceiveJSON`
    json;
    fileData2;
    fileData = {
            "id": 0,
            "duur": 5,
            "titel": "TestTitel",
            "cursusCode": "TestCode",
            "cursusInstanties": [
              {
                "id": 0,
                "startDatum": "2025-12-03",
                "cursusDetailId": 0
              }
            ]
    }
    sendFile(){
      let stringFileData = String(this.fileData2)
      let stringifiedFileData = JSON.stringify({content: stringFileData});
      let headersoptions = new HttpHeaders({'Content-Type': 'text/json'});
      let options = {headers: headersoptions}
      console.log(this.fileData2);
        return this.http.post(this.posturl2, stringifiedFileData, options).subscribe(result => {
        alert(result);
        }, error => console.error(error));
    }  

  
    readThis(inputValue: any) {
      var file:File = inputValue.files[0]; 
      var myReader:FileReader = new FileReader();
  
      myReader.onloadend = (e) => {
       this.fileData2 = myReader.result
      }
  
      myReader.readAsText(file);
    }
}
  
