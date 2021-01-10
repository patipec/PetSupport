import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import * as L from 'leaflet';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  baseUrl = 'http://localhost:3000/data';

  constructor(private http: HttpClient) { }

  makeMarkers(map: L.map): void {
    this.http.get(this.baseUrl).subscribe((res: any) => {
      for ( const c of res ){
        const lat = c.coordinates[0];
        const lon = c.coordinates[1];
        const marker = L.marker([lat, lon]).addTo(map);
        marker.bindPopup(`<strong>${c.Name}</strong><br> <img src="${c.ImageId != null ? c.ImageId : 'assets/PetsitterDetail/default-petsitter-image.png'}" style="width: 40px; height:40px">
                        <p style="display: flex">${c.Price} $/h</p>`);
      }
    });
  }
}
// STEPS TO REPRODUCE JSON SERVER
// OneDrive/Desktop/PetSupport/web/AngularSPA/PetSupport
// json-server --watch data.json
