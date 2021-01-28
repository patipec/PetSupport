import {AfterViewInit, Component, OnInit} from '@angular/core';
import * as L from 'leaflet';
import {MapService} from "./map.service";


@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements AfterViewInit {
  private map;

  constructor(private markerService: MapService) { }

  ngAfterViewInit(): void {
    this.initMap();
    // this.markerService.makeMarkers(this.map);
  }

  private initMap(): void {
    this.map = L.map('map').setView([51.990290599330946, 21.11806915283203], 13);
    const tiles = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      maxZoom: 20,
      attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    });

    tiles.addTo(this.map);
  }
}
