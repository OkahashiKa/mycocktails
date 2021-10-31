import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { MaterialModel } from 'src/app/model/material/materialModel';
import { MaterialDetailModel } from 'src/app/model/material/materialDetailModel';
import { CommonMessageModel } from 'src/app/model/common/commonMessageModel';
import { UserMaterialModel } from 'src/app/model/material/userMaterialModel';
import { catchError, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class MaterialsService {

  private readonly BASE_PATH = environment.API_BASE_PATH + 'materials';

  constructor(
    private httpClient: HttpClient
  ) {};

  getMaterial(materialId: number): Observable<MaterialDetailModel> {
    return this.httpClient.get<MaterialDetailModel>(`${this.BASE_PATH}/${materialId}`);
  }

  getMaterialsList(): Observable<MaterialModel[]> {
    return this.httpClient.get<MaterialModel[]>(`${this.BASE_PATH}`);
  }

  getUserMaterialList(userId: string): Observable<MaterialModel[]> {
    return this.httpClient.get<MaterialModel[]>(`${this.BASE_PATH}/user_material/${userId}`);
  }

  createUserMaterial(userMaterial: UserMaterialModel): Observable<CommonMessageModel> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json'
      })
    };

    return this.httpClient.post<CommonMessageModel>(`${this.BASE_PATH}/user_material`, userMaterial, httpOptions);
  }
}
