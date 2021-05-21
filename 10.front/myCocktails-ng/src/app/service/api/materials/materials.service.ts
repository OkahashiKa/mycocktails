import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { GetServiceInterface, GetService, MaterialModel, MaterialDetailModel } from '@mycocktails/ng-materialapi-service'

@Injectable({
  providedIn: 'root'
})
export class MaterialsService {

  private readonly BASE_PATH = environment.API_BASE_PATH;

  private getService: GetServiceInterface;

  constructor(
    private httpClient: HttpClient
  ) {
    this.getService = new GetService(this.httpClient, this.BASE_PATH, null);
  }

  getMaterial(materialId: number): Observable<MaterialDetailModel> {
    return this.getService.materialIdGet(materialId);
  }

  getMaterialsList(): Observable<MaterialModel[]> {
    return this.getService.materialGet();
  }
}
