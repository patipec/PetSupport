import { HttpClient, HttpEventType } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-upload-photos',
  templateUrl: './upload-photos.component.html',
  styleUrls: ['./upload-photos.component.css']
})
export class UploadPhotosComponent {

    selectedFile: File = null;

    constructor (private http: HttpClient) {

    }

    onFileSelected(event) {
      this.selectedFile = <File>event.target.files[0];
    }
  
      onUpload(){
        console.log('file sent');
        const fd = new FormData();
        fd.append('image', this.selectedFile, this.selectedFile.name)
        console.log(fd);
        this.http.post('https://ng-component-guide-78d02-default-rtdb.firebaseio.com/uploadFile', fd, {
          reportProgress: true,
          observe: 'events'
        } )
        .subscribe( event => {
          if (event.type === HttpEventType.UploadProgress){
            console.log('Upload Progress:' + Math.round(event.loaded / event.total * 100) + '%');
          } else if (event.type === HttpEventType.Response) {
            console.log(event);
          }
          console.log(event);
        });
      }
  }