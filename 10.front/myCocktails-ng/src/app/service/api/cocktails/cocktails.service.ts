import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { CocktailModel } from 'src/app/model/cocktail/cocktailModel';

@Injectable({
  providedIn: 'root'
})
export class CocktailsService {

  private readonly BASE_PATH = environment.API_BASE_PATH + 'cocktails';

  constructor(
    private httpClient: HttpClient
  ) {};

  getCocktail(cocktailId: number): Observable<CocktailModel> {
    return this.httpClient.get<CocktailModel>(`${this.BASE_PATH}/${cocktailId}`);
  }

  getCocktailsList(): Observable<CocktailModel[]> {
    return this.httpClient.get<CocktailModel[]>(`${this.BASE_PATH}`);
  }
}
