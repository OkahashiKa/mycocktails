import { CocktailModel } from '@mycocktails/ng-cocktailapi-service';
import { Action } from '@ngrx/store';

export enum CocktailActionType {
  GetCocktail = '[Cocktail] Get Cocktail',
  GetCocktailList = '[Cocktail] Get Cocktail List',
}

export namespace CocktailAction {
  export class GetCocktail {
    readonly type = CocktailActionType.GetCocktail;
    constructor(public cocktailId: number) {}
  }

  export class GetCocktailList {
    readonly type = CocktailActionType.GetCocktailList;
  }
}