import { CocktailModel } from '@mycocktails/ng-cocktailapi-service';

export namespace CocktailAction {
  export class GetCocktail {
    static readonly type = '[Cocktail] Get Cocktail';
    constructor(public cocktailId: number) {}
  }

  export class GetCocktailList {
      static readonly type = '[Cocktail] Get Cocktail List';
  }
}