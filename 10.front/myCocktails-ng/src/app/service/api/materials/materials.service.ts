import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MaterialsService {

  private readonly BASE_PATH = environment.API_BASE_PATH + 'material';

  constructor() { }
}
