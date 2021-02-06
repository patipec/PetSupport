import {AfterViewInit, Component, Input, OnChanges, OnInit} from '@angular/core';
import * as L from 'leaflet';
import {MapService} from './map.service';
import {Petsitter} from '../../models/petsitter';


@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements AfterViewInit, OnChanges {
  private map;
  @Input()
  public petsitterList: Petsitter[];

  constructor(private markerService: MapService) {
  }

  public ngAfterViewInit(): void {
    this.initMap();
  }

  public ngOnChanges(data): void {
    if (data && this.map) {
      this.markerService.makeMarkers(this.map, this.petsitterList);
    }

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
