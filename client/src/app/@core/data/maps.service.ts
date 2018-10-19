import {Injectable} from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';

export interface MomentumMap {
  id: number;
  name: string;
}

@Injectable()
export class MapsService {

  constructor(private http: HttpClient) {
  }

  searchMaps(query: string): Observable<any> {
    return this.http.get('/api/maps/?search=' + query);
  }
}