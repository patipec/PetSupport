import {Injectable} from '@angular/core';
import * as L from 'leaflet';
import {Petsitter} from '../../../common/models/old-models/petsitter';

@Injectable({
  providedIn: 'root'
})
export class MapService {
  marker = [];


  public makeMarkers(map1: L.map, petsitterList: Petsitter[]): void {

    if (map1 && petsitterList) {
      petsitterList.map(petsitter => {
        const lat = petsitter.coordinates[0].latitude;
        const lon = petsitter.coordinates[0].longitude;
        const marker = L.marker([lat, lon]).addTo(map1);
        marker.bindPopup(`<a href="${this.goToPetsitter()}"><strong>${petsitter.name}</strong><br> <img alt="Petsitter Image" src="${petsitter.imageId != null ? petsitter.imageId : 'assets/PetsitterDetail/default-petsitter-image.png'}" style="width: 40px; height:40px">
                      <p style="display: flex">${petsitter.price} $/h</p></a>`);
        this.marker.push(marker);

      });
    }
  }
  public goToPetsitter(): void {
  }
  public clearMarkers(map: L.map): void{
    // tslint:disable-next-line:prefer-for-of
    for (let i = 0; i < this.marker.length; i++){
      map.removeLayer(this.marker[i]);
    }
  }

}
