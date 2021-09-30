using System;
using mycocktails.library.common.Models;
using mycocktails.library.cocktailApi.Models;

namespace mycocktails.api.cocktailApi.Logics.intarfaces
{
    /// <summary>
    /// Get Cocktail logic intarfase.
    /// </summary>
    public interface IGetCocktailLogic
    {
        /// <summary>
        /// Get cocktail logic by id.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetCocktail(int id);

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetCocktailList(SearchCocktailConditionModel searchCocktailCondition);
    }
}
