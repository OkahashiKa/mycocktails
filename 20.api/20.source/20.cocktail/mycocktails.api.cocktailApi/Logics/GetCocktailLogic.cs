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
        public ApiResponse GetCocktailList(SearchCocktailConditionModel searchCocktailCondition)
        {
            var result = new List<CocktailModel>();

            try
            {
                // Get cocktail list.
                if (searchCocktailCondition == null)
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

                // Search cocktails.
                else
                {
                    IQueryable<MCocktail> query = context.MCocktails;

                    // SerchString
                    if (searchCocktailCondition.SearchString != null)
                    {
                        query = query.Where(c => c.Name.Contains(searchCocktailCondition.SearchString));
                    }

                    // Search material id list.
                    if (searchCocktailCondition.MaterialIdList != null)
                    {
                        // Get search target cocktail id.
                        List<int> targetCocktailIdList = new List<int>();

                        // Patterns to get cocktails made with current materials.
                        if (searchCocktailCondition.MaterialSearchType == "AND")
                        {
                            List<int> targetCocktailIdListTmp = context.MCocktailRecipis
                                .Where(cr =>
                                    searchCocktailCondition.MaterialIdList.Contains(cr.MaterialId)
                                )
                                .Select(cr => cr.CocktailId)
                                .Distinct()
                                .ToList();

                            foreach (var coctailId in targetCocktailIdListTmp)
                            {
                                var needMaterialIdList = context.MCocktailRecipis
                                    .Where(cr => cr.CocktailId == coctailId)
                                    .Select(cr => cr.MaterialId)
                                    .ToList();

                                // Get intersection of materials needed for a cocktail and the selected materials.
                                var commonCocktailIdList = searchCocktailCondition.MaterialIdList.Intersect(needMaterialIdList).ToList();

                                if (commonCocktailIdList.SequenceEqual(needMaterialIdList))
                                {
                                    // Add search target cocktail id.
                                    targetCocktailIdList.Add(coctailId);
                                }
                            }
                        }
                        // Pattern to get cocktails related to selected materials.
                        else
                        {
                            targetCocktailIdList = context.MCocktailRecipis
                                .Where(cr =>
                                    searchCocktailCondition.MaterialIdList.Contains(cr.MaterialId)
                                )
                                .Select(cr => cr.CocktailId)
                                .Distinct()
                                .ToList();
                        }

                        query = query.Where(c => targetCocktailIdList.Contains(c.Id));
                    }

                    result = query
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
