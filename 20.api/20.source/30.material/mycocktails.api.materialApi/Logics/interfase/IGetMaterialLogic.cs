using mycocktails.library.common.Models;

namespace mycocktails.api.materialApi.Logics.interfaces
{
    /// <summary>
    /// Get material api logic interfase.
    /// </summary>
    public interface IGetMaterialLogic
    {
        /// <summary>
        /// Get cocktail logic by id.
        /// </summary>
        /// <returns>Material info.</returns>
        public ApiResponse GetMaterial(int id);

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns>Material info list.</returns>
        public ApiResponse GetMaterialList();

        /// <summary>
        /// Get user cocktail list logic.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>User material info list.</returns>
        public ApiResponse GetUserMaterialList(string userId);
    }
}
