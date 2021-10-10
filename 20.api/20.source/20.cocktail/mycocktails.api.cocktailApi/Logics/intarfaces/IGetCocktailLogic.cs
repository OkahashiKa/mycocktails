using mycocktails.library.common.Models;

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
        /// <returns>cocktail info.</returns>
        public ApiResponse GetCocktail(int id);

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns>cocktail info list.</returns>
        public ApiResponse GetCocktailList();
    }
}
