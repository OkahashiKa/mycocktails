using mycocktails.library.common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mycocktails.api.cocktailApi.Logics.intarfaces
{
    /// <summary>
    /// Create cocktail logic intarface.
    /// </summary>
    public interface ICreateCocktailLogic
    {
        /// <summary>
        /// Create cocktail logic.
        /// </summary>
        /// <returns></returns>
        public ApiResponse CreateCocktail();

        /// <summary>
        /// Create multiple cocktails logic.
        /// </summary>
        /// <returns></returns>
        public ApiResponse BulkCreateCocktail();
    }
}
