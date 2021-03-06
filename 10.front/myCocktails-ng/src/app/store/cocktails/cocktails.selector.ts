import { Selector } from "@ngxs/store";
import { CocktailStateModel, CocktailState } from "src/app/store/cocktails/cocktails.state"

export class CocktailSelector {

  @Selector([CocktailState])
  static selectedCocktail(state: CocktailStateModel) {
    return state.selectedCocktail;
  }

  @Selector([CocktailState])
  static cocktailList(state: CocktailStateModel) {
    return state.cocktailList;
  }

  @Selector([CocktailState])
  static userCocktailList(state: CocktailStateModel) {
    return state.userCocktailList;
  }
}