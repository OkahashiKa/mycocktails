using mycocktails.library.common.Models;
using mycocktails.library.cocktailApi.Models;

namespace mycocktails.api.cocktailApi.Logics.intarfaces
{
    /// <summary>
    /// Search cocktail info logic interface.
    /// </summary>
    public interface ISearchCocktailLogic
    {
        /// <summary>
        /// Search cocktail info logic.
        /// </summary>
        /// <param name="searchCocktailCondition">Search cocktail condition model.</param>
        /// <returns>Cocktail info.</returns>
        public ApiResponse SearchCocktail(SearchCocktailConditionModel searchCocktailCondition);
    }
}
