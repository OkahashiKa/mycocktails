export enum CocktailActionType {
  GetCocktail = '[Cocktail] Get Cocktail',
  GetCocktailList = '[Cocktail] Get Cocktail List',
}

export namespace CocktailAction {
  export class GetCocktail {
    static readonly type = CocktailActionType.GetCocktail;
    constructor(public cocktailId: number) {}
  }

  export class GetCocktailList {
    static readonly type = CocktailActionType.GetCocktailList;
  }
}