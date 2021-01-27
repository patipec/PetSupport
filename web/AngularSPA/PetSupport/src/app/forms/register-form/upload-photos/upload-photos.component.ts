import { HttpClient, HttpEventType } from '@angular/common/http';
import { ChangeDetectorRef, Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AngularFileUploaderConfig } from 'angular-file-uploader';

@Component({
  selector: 'app-upload-photos',
  templateUrl: './upload-photos.component.html',
  styleUrls: ['./upload-photos.component.css']
})
export class UploadPhotosComponent  implements OnInit {

  url;
  selectedFile: File = null;

  //dzialajace z obrazkiem
// constructor() { }

//od gostka z postem
constructor (private http: HttpClient) { }

ngOnInit() {
}

//dzialajace z obrazkiem
  onSelectFile(event) {
    this.selectedFile = <File>event.target.files[0];
    if (event.target.files && event.target.files[0]) {
      var reader = new FileReader();

      reader.readAsDataURL(event.target.files[0]); // read file as data url
      reader.onload = (event) => { // called once readAsDataURL is completed
        this.url = event.target.result;
    }
  }
}




  //   selectedFile: File = null;
  //   url = '';
    
// od gostka z postem
  //   onFileSelected(event) {
  //     this.selectedFile = <File>event.target.files[0];
  //   }

  //gostka z postem
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

    

