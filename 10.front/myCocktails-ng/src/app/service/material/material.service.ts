import { Injectable } from '@angular/core';
import { material } from '../../material';
import { MATERIALS } from '../../moc-materials';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MaterialService {

  constructor() { }

  getMaterials(): Observable<material[]>{
    return of(MATERIALS);
  }
}
