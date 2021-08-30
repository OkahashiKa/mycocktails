import { Injectable } from '@angular/core';
import { State, Action, StateContext } from '@ngxs/store';
import { of } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { CocktailModel } from 'src/app/model/cocktail/cocktailModel';
import { CocktailAction } from 'src/app/store/cocktails/cocktails.action';
import { CocktailsService } from 'src/app/service/api/cocktails/cocktails.service';

export interface CocktailStateModel {
  selectedCocktail: CocktailModel;
  cocktailList: CocktailModel[];
}

@State<CocktailStateModel>({
  name: 'cocktail',
  defaults: {
    selectedCocktail: null,
    cocktailList: [],
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
                  selectedCocktail: result
              })
          })
      )
  }

  @Action(CocktailAction.GetCocktailList)
  getCocktilList({ getState, setState }: StateContext<CocktailStateModel>) {
      const state = getState();
      return this.cocktailSevice.getCocktailsList().pipe(
          tap(result => {
              setState({
                  ...state,
                  cocktailList: result,
              });
          }),
          catchError(error =>{
              return of(error);
          }),
      );
  }
}