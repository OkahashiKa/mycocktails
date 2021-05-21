using Microsoft.Extensions.Logging;
using mycocktails.api.materialApi.Logics.intarfaces;
using mycocktails.api.materialApi.Models;
using mycocktails.library.common.Logics;
using mycocktails.library.common.Models;
using mycocktails.library.entity.Models;
using mycocktails.library.materialApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace mycocktails.api.materialApi.Logics
{
    /// <summary>
    /// Get Material api logic.
    /// </summary>
    public class GetLogic : IGetLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<GetLogic> logger;

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="context">DBcontext</param>
        /// <param name="logger">logger</param>
        public GetLogic(
            MyCocktailsDBContext context,
            ILogger<GetLogic> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        #region Get cocktails.

        /// <summary>
        /// Get material by id logic.
        /// </summary>
        /// <returns>ApiResponse</returns>
        public ApiResponse GetMaterial(int id)
        {
            var result = new MaterialDetailModel();

            try
            {
                result.MaterialInfo = context.MMaterials
                    .Where(m => m.Id == id)
                    .Select(m => new MaterialModel
                    {
                        MaterialId = m.Id,
                        MaterialName = m.Name,
                        CategoryId = m.Category.Id,
                        CategoryName = m.Category.Name,
                    })
                    .FirstOrDefault();

                result.CocktailList = context.TCocktailMaterials
                    .Where(cm => cm.MaterialId == id)
                    .Select(cm => new CocktailModel
                    {
                        CocktailId = cm.Cocktail.Id,
                        CocktailName = cm.Cocktail.Name,
                        CocktailRemarks = cm.Cocktail.Remarks,
                        CocktailImage = cm.Cocktail.Image,
                    })
                    .ToList();

                // Not found target cocktail by id. 
                if (result == null)
                {
                    // TODO: Constantization of error messages.
                    string msg = "The target material was not found.";
                    logger.LogError($"{msg}");
                    return LogicCommonMethods.GenerateErrorResponse(HttpStatusCode.NotFound, msg);
                }
            }
            catch (Exception ex)
            {
                logger.LogError((ex.InnerException == null) ? $" : {ex.Message}" : $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}");
                return LogicCommonMethods.GenerateErrorResponse(ex);
            }

            return new SuccessResponse<MaterialDetailModel>(HttpStatusCode.OK, result);
        }

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns>ApiResponse</returns>
        public ApiResponse GetMaterialList()
        {
            var result = new List<MaterialModel>();

            try
            {
                // Get cocktail list from DB.
                result = context.MMaterials
                    .Select(m => new MaterialModel
                    {
                        MaterialId = m.Id,
                        MaterialName = m.Name,
                        CategoryId = m.Category.Id,
                        CategoryName = m.Category.Name,
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

            return new SuccessResponse<List<MaterialModel>>(HttpStatusCode.OK, result);
        }

        #endregion
    }
}
