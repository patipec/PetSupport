import {Injectable} from '@angular/core';
import {environment} from '../../../environments/environment';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable} from 'rxjs';

interface HttpOptions {
  headers?: HttpHeaders | {
    [header: string]: string | string[];
  };
  observe?: 'body';
  params?: HttpParams | {
    [param: string]: string | string[];
  };
  reportProgress?: boolean;
  responseType?: 'json';
  withCredentials?: boolean;
}

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  public backendApiUrl = environment.apiUrl;

  constructor(private httpClient: HttpClient) {
  }

  public get<T>(url: string, options?: HttpOptions): Observable<T> {
    return this.httpClient.get<T>(this.createUrl(url), options);
  }

  public post<T>(url: string, body: unknown | null, options?: HttpOptions): Observable<T> {
    return this.httpClient.post<T>(this.createUrl(url), body, options);
  }

  public put<T>(url: string, body: unknown | null, options?: HttpOptions): Observable<T> {
    return this.httpClient.put<T>(this.createUrl(url), body, options);
  }

  public delete<T>(url: string, options?: HttpOptions): Observable<T> {
    return this.httpClient.delete<T>(this.createUrl(url), options);
  }

  public objectToParams(obj: unknown): HttpParams {
      let params = new HttpParams();

      Object.entries(obj).map(([k, v]) => {
        params = params.append(k, v);
      });
      return params;
  }
  private createUrl(url: string): string {
    return `${this.backendApiUrl}/${url}`;
  }
}
