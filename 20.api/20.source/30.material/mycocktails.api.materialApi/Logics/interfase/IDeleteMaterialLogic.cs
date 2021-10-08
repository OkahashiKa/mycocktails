using mycocktails.library.common.Models;

namespace mycocktails.api.materialApi.Logics.interfaces
{
    /// <summary>
    /// Delete user material api logic interfase.
    /// </summary>
    public interface IDeleteMaterialLogic
    {
        /// <summary>
        /// Delete user material api logic.
        /// </summary>
        /// <param name="userId">User id</param>
        /// <param name="materialId">Material id</param>
        /// <returns>Response message.</returns>
        public ApiResponse DeleteUserMaterial(string userId, int materialId);
    }
}
