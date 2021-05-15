import { Selector } from "@ngxs/store";
import { CocktailStateModel, CocktailState } from "src/app/store/cocktails/cocktails.state"

export class CocltailSelector {

  @Selector([CocktailState])
  static selectedCocktail(state: CocktailStateModel) {
    return state.selectedCocktail;
  }

  @Selector([CocktailState])
  static cocktailList(state: CocktailStateModel) {
    return state.cocktailList;
  }
}