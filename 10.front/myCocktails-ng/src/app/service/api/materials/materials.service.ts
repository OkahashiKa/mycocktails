import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { GetMaterialsServiceInterface, GetMaterialsService, MaterialModel, MaterialDetailModel } from '@mycocktails/ng-materialapi-service'

@Injectable({
  providedIn: 'root'
})
export class MaterialsService {

  private readonly BASE_PATH = environment.API_BASE_PATH;

  private getService: GetMaterialsServiceInterface;

  constructor(
    private httpClient: HttpClient
  ) {
    this.getService = new GetMaterialsService(this.httpClient, this.BASE_PATH, null);
  }

  getMaterial(materialId: number): Observable<MaterialDetailModel> {
    return this.getService.idGet(materialId);
  }

  getMaterialsList(): Observable<MaterialModel[]> {
    return this.getService.rootGet();
  }
}
