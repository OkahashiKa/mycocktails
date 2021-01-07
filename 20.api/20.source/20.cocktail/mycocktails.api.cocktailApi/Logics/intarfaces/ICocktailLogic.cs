using System;
using mycocktails.library.common.Models;

namespace mycocktails.api.cocktailApi.Logics.intarfaces
{
    /// <summary>
    /// Cocktails api logic intarfase.
    /// </summary>
    public interface ICocktailLogic
    {
        /// <summary>
        /// Get cocktail logic by id.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetCocktail();

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetCocktailList();
    }
}
