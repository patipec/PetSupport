import {AfterViewInit, Component, Input, OnChanges, OnInit} from '@angular/core';
import * as L from 'leaflet';
import {MapService} from './map.service';
import {Petsitter} from '../../models/petsitter';


@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.css']
})
export class MapComponent implements AfterViewInit, OnChanges, OnInit {
  private map;
  @Input()
  public petsitterList: Petsitter[];
  constructor(private markerService: MapService) {
  }

  public ngOnInit() {
    console.log(this.markerService.petsitterCurrentPositionService);
  }

  public ngAfterViewInit(): void {
    this.initMap();
    console.log(this.markerService.petsitterCurrentPositionService);
  }

  public ngOnChanges(data): void {

    if (data && this.map) {
      this.markerService.clearMarkers(this.map);
      this.markerService.makeMarkers(this.map, this.petsitterList);
    }

  }

  private initMap(): void {
    this.map = L.map('map').setView([this.markerService.petsitterCurrentPositionService.latitude,
      this.markerService.petsitterCurrentPositionService.longitude], 13);
    const tiles = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
      maxZoom: 20,
      attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    });

    tiles.addTo(this.map);
  }
  // public initPetsitterCords(): void{
  //   this.petsitterCurrentPosition.latitude = this.petsitterList[0].coordinates[0].lattiude;
  //   this.petsitterCurrentPosition.longitude = this.petsitterList[0].coordinates[0].longtitude;
  //   console.log(this.petsitterCurrentPosition);
  // }
}
