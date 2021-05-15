import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CocktailServiceInterface, CocktailService, CocktailModel } from '@mycocktails/ng-cocktailapi-service'
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CocktailsService {

  private readonly BASE_PATH = environment.API_BASE_PATH + 'cocktail';

  private cocktailService: CocktailServiceInterface;

  constructor(
    private httpClient: HttpClient
  ) {
    this.cocktailService = new CocktailService(this.httpClient, this.BASE_PATH, null);
   }

  //#region cocktail api.

  getCocktail(cocktailId: number): Observable<CocktailModel> {
    return this.cocktailService.cocktailIdGet(cocktailId);
  }

  getCocktailsList(): Observable<CocktailModel[]> {
    return this.cocktailService.cocktailGet();
  }

  //#endregion
}
