import { Injectable } from '@angular/core';
import {Observable, of} from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ServiceType {
  constructor() { }
  getServicesTypes(): Observable<string[]>{
    return of(['Monthly', 'Annual', 'Lifetime']);
  }

}
