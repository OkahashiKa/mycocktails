using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.Extensions.Logging;
using mycocktails.api.cocktailApi.Logics.intarfaces;
using mycocktails.library.cocktailApi.Models;
using mycocktails.library.common.Logics;
using mycocktails.library.common.Models;
using mycocktails.library.entity.Models;

namespace mycocktails.api.cocktailApi.Logics
{
    /// <summary>
    /// Cocktails api logic.
    /// </summary>
    public class GetCocktailLogic : IGetCocktailLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<GetCocktailLogic> logger;

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="context">DBcontext</param>
        /// <param name="logger">logger</param>
        public GetCocktailLogic(
            MyCocktailsDBContext context,
            ILogger<GetCocktailLogic> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        #region Get cocktails by id.

        /// <summary>
        /// Get cocktail logic by id.
        /// </summary>
        /// <returns>ApiResponse</returns>
        public ApiResponse GetCocktail(int id)
        {
            var result = new CocktailDetailModel();

            try
            {
                result = context.MCocktails
                    .Where(c => c.Id == id)
                    .Select(c => new CocktailDetailModel
                    {
                        CocktailId = c.Id,
                        CocktailName = c.Name
                    })
                    .FirstOrDefault();

                result.MaterialIdList = context.MCocktailRecipis
                    .Where(cr => cr.CocktailId == id)
                    .Select(cr => cr.MaterialId)
                    .ToList();

                // Not found target cocktail by id. 
                if (result == null)
                {
                    // TODO: Constantization of error messages.
                    string msg = "The target cocktail was not found.";
                    logger.LogError($"{msg}");
                    return LogicCommonMethods.GenerateErrorResponse(HttpStatusCode.NotFound, msg);
                }
            }
            catch (Exception ex)
            {
                logger.LogError((ex.InnerException == null) ? $" : {ex.Message}" : $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}");
                return LogicCommonMethods.GenerateErrorResponse(ex);
            }

            return new SuccessResponse<CocktailDetailModel>(HttpStatusCode.OK, result);
        }

        #endregion

        #region Get cocktail list.

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns>ApiResponse</returns>
        public ApiResponse GetCocktailList()
        {
            var result = new List<CocktailModel>();

            try
            {
                // Get cocktail list from DB.
                result = context.MCocktails
                    .Select(c => new CocktailModel
                    {
                        CocktailId = c.Id,
                        CocktailName = c.Name
                    })
                    .ToList();

                // Cocktail record not found. 
                if (result.Count() == 0)
                {
                    // TODO: Constantization of error messages.
                    string msg = "There is no cocktail record.";
                    logger.LogError($"{msg}");
                    return LogicCommonMethods.GenerateErrorResponse(HttpStatusCode.NotFound, msg);
                }
            }
            catch(Exception ex)
            {
                logger.LogError((ex.InnerException == null) ? $" : {ex.Message}" : $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}");
                return LogicCommonMethods.GenerateErrorResponse(ex);
            }

            return new SuccessResponse<List<CocktailModel>>(HttpStatusCode.OK, result);
        }

        #endregion
    }
}
