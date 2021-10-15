using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mycocktails.api.materialApi.Logics.interfaces;
using mycocktails.library.common.Logics;
using mycocktails.library.common.Models;
using mycocktails.library.entity.Models;
using mycocktails.library.materialApi.Models;
using System;
using System.Net;
using System.Linq;
using CommonMessageModel = mycocktails.library.common.Models.CommonMessageModel;

namespace mycocktails.api.materialApi.Logics
{
    /// <summary>
    /// Create user material api logic.
    /// </summary>
    public class CreateMaterialLogic : ICreateMaterialLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<CreateMaterialLogic> logger;

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="context">DBcontext</param>
        /// <param name="logger">logger</param>
        public CreateMaterialLogic(
            MyCocktailsDBContext context,
            ILogger<CreateMaterialLogic> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        #region Create user materials.

        /// <summary>
        /// Create user material api logic.
        /// </summary>
        /// <param name="userMaterialModel">User material info pram.</param>
        /// <returns></returns>
        public ApiResponse CreateUserMaterial(UserMaterialModel userMaterialModel)
        {
            try
            {
                // Get material id list.
                var materialIdList = this.context.MMaterials
                    .Select(m => m.Id)
                    .ToList();

                var createTime = DateTime.Now;

                foreach (var targetMaterialId in userMaterialModel.MaterialIdList)
                {
                    if (!materialIdList.Contains(targetMaterialId))
                    {
                        // TODO: Constantization of error messages.
                        string msg = "Some of the target materials dose not exist.";
                        logger.LogError($"{msg}");
                        return LogicCommonMethods.GenerateErrorResponse(HttpStatusCode.BadRequest, msg);
                    }

                    // Insert user material info.
                    context.UserMaterials.Add(new UserMaterial
                    {
                        UserId = userMaterialModel.UserId,
                        MaterialId = targetMaterialId,
                        CreateAt = createTime,
                        UpdateAt = createTime
                    });
                }

                // Execute query.
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                logger.LogError((ex.InnerException == null) ? $" : {ex.Message}" : $" : {ex.Message} {Environment.NewLine} {ex.InnerException.Message}");
                return LogicCommonMethods.GenerateErrorResponse(ex);
            }

            CommonMessageModel result = new CommonMessageModel
            {
                Msg = "The user material resource has been created successfully."
            };

            return new SuccessResponse<CommonMessageModel>(HttpStatusCode.OK, result);
        }

        #endregion
    }
}
