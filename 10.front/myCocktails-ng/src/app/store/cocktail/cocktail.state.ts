import { Injectable } from '@angular/core';
import { State, Action, StateContext, Actions } from '@ngxs/store';
import { CocktailModel } from '@mycocktails/ng-cocktailapi-service';
import { CocktailAction } from 'src/app/store/cocktail/cocktail.actions';
import { CocktailsService } from 'src/app/service/api/cocktail/cocktails-api.service';
import { tap } from 'rxjs/operators';

export class CocktailStateModel {
  cocktailList: CocktailModel[];
  selectedCocktails: CocktailModel;
}

@State<CocktailStateModel>({
  name: 'cocktails',
  defaults: {
    cocktailList: [],
    selectedCocktails: null,
  },
})
@Injectable()
export class CocktailState {
    constructor(
        private cocktailSevice: CocktailsService
    ) {}

    @Action(CocktailAction.GetCocktail)
    getCocktail(ctx: StateContext<CocktailStateModel>, action: CocktailAction.GetCocktail) {
        return this.cocktailSevice.getCocktail(action.cocktailId).pipe(
            tap((result) => {
                ctx.patchState({
                    selectedCocktails: result
                })
            })
        )
    }

    @Action(CocktailAction.GetCocktailList)
    getCocktilList(ctx: StateContext<CocktailStateModel>) {
        return this.cocktailSevice.getCocktailsList().pipe(
            tap((result) => {
                ctx.patchState({
                    cocktailList: result
                })
            })
        )
    }
}