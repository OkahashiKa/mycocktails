using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mycocktails.api.materialApi.Logics.intarfaces;
using mycocktails.library.common.Logics;
using mycocktails.library.common.Models;
using mycocktails.library.entity.Models;
using mycocktails.library.materialApi.Models;
using System;
using System.Net;
using CommonMessageModel = mycocktails.library.common.Models.CommonMessageModel;

namespace mycocktails.api.materialApi.Logics
{
    /// <summary>
    /// Create user material api logic.
    /// </summary>
    public class CreateUserMaterialLogic : ICreateUserMaterialLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<CreateUserMaterialLogic> logger;

        /// <summary>
        /// Constractor
        /// </summary>
        /// <param name="context">DBcontext</param>
        /// <param name="logger">logger</param>
        public CreateUserMaterialLogic(
            MyCocktailsDBContext context,
            ILogger<CreateUserMaterialLogic> logger)
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
                context.UserMaterials.Add(new UserMaterial
                {
                    UserId = userMaterialModel.UserId,
                    MaterialId = userMaterialModel.MaterialId,
                    CreateAt = DateTime.Now,
                    UpdateAt = DateTime.Now
                });

                // insert data.
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
