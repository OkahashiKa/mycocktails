using System;
using System.Linq;
using System.Net;
using Microsoft.Extensions.Logging;
using mycocktails.api.materialApi.Logics.interfaces;
using mycocktails.library.common.Logics;
using mycocktails.library.common.Models;
using mycocktails.library.entity.Models;

namespace mycocktails.api.materialApi.Logics
{
    /// <summary>
    /// Delete material api logic.
    /// </summary>
    public class DeleteMaterialLogic : IDeleteMaterialLogic
    {
        private readonly MyCocktailsDBContext context;
        private readonly ILogger<DeleteMaterialLogic> logger;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="context">context</param>
        /// <param name="logger">logegr</param>
        public DeleteMaterialLogic(
            MyCocktailsDBContext context,
            ILogger<DeleteMaterialLogic> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        /// <summary>
        /// Delete user material api logic.
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="materialId">Material id</param>
        /// <returns>Response message.</returns>
        public ApiResponse DeleteUserMaterial(string userId, int materialId)
        {
            try
            {
                // Get target user material info.
                var targetUserMaterials = context.UserMaterials
                    .Single(um =>
                        um.UserId == userId &&
                        um.MaterialId == materialId);

                // Delete data.
                context.UserMaterials.Remove(targetUserMaterials);

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
                Msg = "The user material resource has been deleted successfully."
            };

            return new SuccessResponse<CommonMessageModel>(HttpStatusCode.OK, result);
        }
    }
}
