
import { Component, OnInit } from '@angular/core';
import { AngularFileUploaderConfig } from 'angular-file-uploader';

@Component({
  selector: 'app-photo-gallery',
  templateUrl: './photo-gallery.component.html',
  styleUrls: ['./photo-gallery.component.css']
})
export class PhotoGalleryComponent  {

  
  resetUpload1: boolean;
  resetUpload2: boolean;
  resetUpload3: boolean;


  afuConfig1: AngularFileUploaderConfig = { 
    id: 112233,
    multiple: true,
    uploadAPI: {
      url: 'https://slack.com/api/files.upload',
    }
  };

  afuConfig2: AngularFileUploaderConfig = {
    theme: 'attachPin',
    hideProgressBar: true,
    hideResetBtn: true,
    maxSize: 1,
    uploadAPI: {
      url: 'https://slack.com/api/files.upload',
    },
    formatsAllowed: '.jpg,.png',
    multiple: true,
  };

  afuConfig3: AngularFileUploaderConfig = {
    theme: 'dragNDrop',
    hideProgressBar: true,
    hideResetBtn: true,
    hideSelectBtn: true,
    maxSize: 1,
    uploadAPI: {
      url: 'https://slack.com/api/files.upload',
    },
    formatsAllowed: '.jpg,.jpeg,.png',
    multiple: true,
  };

  constructor() {
  }

  docUpload(event) {
    console.log('ApiResponse -> docUpload -> Event: ',event);
  }
}

  // images = [];
  //     onSelectFiles(event) {
  //       if (event.target.files && event.target.files[0]) {
  //           var filesAmount = event.target.files.length;
  //           for (let i = 0; i < filesAmount; i++) {
  //                   var reader = new FileReader();
    
  //                   reader.onload = (event:any) => {
  //                     console.log(event.target.result);
  //                      this.images.push(event.target.result); 
  //                   }
    
  //                   reader.readAsDataURL(event.target.files[i]);
  //           }
  //       }
  //     }

// }
