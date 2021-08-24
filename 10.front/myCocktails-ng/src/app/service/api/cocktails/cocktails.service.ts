import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GetCocktailsServiceInterface, GetCocktailsService, CocktailModel } from '@mycocktails/ng-cocktailapi-service'
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CocktailsService {

  private readonly BASE_PATH = environment.API_BASE_PATH + 'cocktail';

  private cocktailService: GetCocktailsServiceInterface;

  constructor(
    private httpClient: HttpClient
  ) {
    this.cocktailService = new GetCocktailsService(this.httpClient, this.BASE_PATH, null);
   }

  getCocktail(cocktailId: number): Observable<CocktailModel> {
    return this.cocktailService.idGet(cocktailId);
  }

  getCocktailsList(): Observable<CocktailModel[]> {
    return this.cocktailService.rootGet();
  }
}
