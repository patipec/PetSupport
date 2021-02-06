import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import * as L from 'leaflet';
import {Petsitter} from '../../models/petsitter';
import {publish} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class MapService {
  marker = [];


  public makeMarkers(map1: L.map, petsitterList: Petsitter[]): void {

    if (map1 && petsitterList) {
      petsitterList.map(petsitter => {
        const lat = petsitter.coordinates[0].lattiude;
        const lon = petsitter.coordinates[0].longtitude;
        const marker = L.marker([lat, lon]).addTo(map1);
        marker.bindPopup(`<a href="${this.goToPetsitter(petsitter.id)}"><strong>${petsitter.name}</strong><br> <img src="${petsitter.imageId != null ? petsitter.imageId : 'assets/PetsitterDetail/default-petsitter-image.png'}" style="width: 40px; height:40px">
                      <p style="display: flex">${petsitter.price} $/h</p></a>`);
        this.marker.push(marker);

      });
    }
  }
  public goToPetsitter(d): void {
  }
  public clearMarkers(map: L.map): void{
    for (let i = 0; i < this.marker.length; i++){
      map.removeLayer(this.marker[i]);
    }
  }

}
