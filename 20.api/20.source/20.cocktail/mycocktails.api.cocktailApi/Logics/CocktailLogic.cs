using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.Extensions.Logging;
using mycocktails.api.cocktailApi.Logics.intarfaces;
using mycocktails.library.cocktailApi.Models;
using mycocktails.library.common.Models;
using mycocktails.library.entity.Models;

namespace mycocktails.api.cocktailApi.Logics
{
    public class CocktailLogic : ICocktailLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<CocktailLogic> logger;

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="context">DBcontext</param>
        /// <param name="logger">logger</param>
        public CocktailLogic(
            MyCocktailsDBContext context,
            ILogger<CocktailLogic> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        #region Get cocktails.

        /// <summary>
        /// Get cocktail logic by id.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetCocktail(int id)
        {
            var result = new CocktailModel();

            try
            {
                result = context.MCocktails
                    .Where(c => c.Id == id)
                    .Select(c => new CocktailModel
                    {
                        CocktailId = c.Id,
                        CocktailName = c.Name
                    })
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                // TODO: Cut out to the common part.
                CommonMessageModel error = new CommonMessageModel
                {
                    Msg = ex.Message
                };

                logger.LogError($"{ex.Message}");
                return new ErrorResponse<CommonMessageModel>(HttpStatusCode.InternalServerError, error, ex.InnerException?.Message ?? ex.Message);
            }

            return new SuccessResponse<CocktailModel>(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetCocktailList()
        {
            var result = new List<CocktailModel>();

            try
            {
                result = context.MCocktails
                    .Select(c => new CocktailModel
                    {
                        CocktailId = c.Id,
                        CocktailName = c.Name
                    })
                    .ToList();
            }
            catch(Exception ex)
            {
                // TODO: Cut out to the common part.
                CommonMessageModel error = new CommonMessageModel
                {
                    Msg = ex.Message
                };

                logger.LogError($"{error.Msg}");
                return new ErrorResponse<CommonMessageModel>(HttpStatusCode.InternalServerError, error, ex.InnerException?.Message ?? ex.Message);
            }

            return new SuccessResponse<List<CocktailModel>>(HttpStatusCode.OK, result);
        }

        #endregion
    }
}
