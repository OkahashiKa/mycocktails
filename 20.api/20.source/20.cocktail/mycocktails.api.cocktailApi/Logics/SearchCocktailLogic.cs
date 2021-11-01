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
    /// Search cocktail info logic.
    /// </summary>
    public class SearchCocktailLogic : ISearchCocktailLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<SearchCocktailLogic> logger;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context">DB contest.</param>
        /// <param name="logger">Logegr</param>
        public SearchCocktailLogic(
            MyCocktailsDBContext context,
            ILogger<SearchCocktailLogic> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        /// <summary>
        /// Search cocktail info logic.
        /// </summary>
        /// <param name="searchCocktailCondition">Search cocktail condition model.</param>
        /// <returns>Cocktail info.</returns>
        public ApiResponse SearchCocktail(SearchCocktailConditionModel searchCocktailCondition)
        {
            var result = new List<CocktailModel>();

            try
            {
                IQueryable<MCocktail> query = context.MCocktails;

                // SerchString
                if (searchCocktailCondition.SearchString != null)
                {
                    query = query
                        .Where(c => c.Name.Contains(searchCocktailCondition.SearchString));
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
                            var commonMaterialIdList = searchCocktailCondition.MaterialIdList.Intersect(needMaterialIdList).ToList();

                            // Sort 
                            commonMaterialIdList.Sort();
                            needMaterialIdList.Sort();

                            if (commonMaterialIdList.SequenceEqual(needMaterialIdList))
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

                    query = query
                        .Where(c => targetCocktailIdList.Contains(c.Id));
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
            catch (Exception ex)
            {
                logger.LogError((ex.InnerException == null) ? $" : {ex.Message}" : $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}");
                return LogicCommonMethods.GenerateErrorResponse(ex);
            }

            return new SuccessResponse<List<CocktailModel>>(HttpStatusCode.OK, result);
        }
    }
}
