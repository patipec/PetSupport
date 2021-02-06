import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import * as L from 'leaflet';
import {Petsitter} from '../../models/petsitter';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  public makeMarkers(map: L.map, petsitterList: Petsitter[]): void {
    if (map && petsitterList) {
      petsitterList.map(petsitter => {
        const lat = petsitter.coordinates[0].lattiude;
        const lon = petsitter.coordinates[0].longtitude;
        if(lat && lon) {
          const marker = L.marker([lat, lon]).addTo(map);
          marker.bindPopup(`<a href="${this.goToPetsitter(petsitter.id)}"><strong>${petsitter.name}</strong><br> <img src="${petsitter.imageId != null ? petsitter.imageId : 'assets/PetsitterDetail/default-petsitter-image.png'}" style="width: 40px; height:40px">
                        <p style="display: flex">${petsitter.price} $/h</p></a>`);
        }

      });
    }
  }
  public goToPetsitter(d): void {
    console.log(d);
  }
}


// STEPS TO REPRODUCE JSON SERVER
// OneDrive/Desktop/PetSupport/web/AngularSPA/PetSupport
// json-server --watch data.json
