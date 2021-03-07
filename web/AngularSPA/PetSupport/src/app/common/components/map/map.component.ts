import {Component, Input, OnChanges, OnInit} from '@angular/core';
import * as L from 'leaflet';
import {MapService} from './map.service';
import {Petsitter} from '../../models/petsitter';


@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.scss']
})
export class MapComponent implements OnChanges, OnInit {
  private map;
  lat: number;
  lng: number;
  @Input()
  public petsitterList: Petsitter[];
  constructor(private markerService: MapService) {
  }

  public ngOnInit(): void {
    this.getUserCurrentPostion();
  }


  public ngOnChanges(data): void {
    if (data && this.map) {
      this.markerService.clearMarkers(this.map);
      this.markerService.makeMarkers(this.map, this.petsitterList);
    }

  }

  private initMap(): void {
    this.map = L.map('map').setView([this.lat, this.lng], 13);
    const tiles = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      maxZoom: 20,
      attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    });

    tiles.addTo(this.map);
  }

  getUserCurrentPostion(): void {
    navigator.geolocation.getCurrentPosition((position) => {
        this.lat = position.coords.latitude;
        this.lng = position.coords.longitude;
        this.initMap();
      },
      () => {
        /*        this.petsitterList
                if (/!*this.petsitterList[0]?.coordinates[0]*!/ false) {
                  this.lat = +this.petsitterList[0].coordinates[0].latitude;
                  this.lng = +this.petsitterList[0].coordinates[0].longitude;
                } else {*/
        this.lat = 52.23;
        this.lng = 21;
        /*        }*/
        this.initMap();
      },
      {timeout: 5000}
    );
  }

  // public initPetsitterCords(): void{
  //   this.petsitterCurrentPosition.latitude = this.petsitterList[0].coordinates[0].lattiude;
  //   this.petsitterCurrentPosition.longitude = this.petsitterList[0].coordinates[0].longtitude;
  //   console.log(this.petsitterCurrentPosition);
  // }
}
