using mycocktails.library.common.Models;
using mycocktails.library.materialApi.Models;

namespace mycocktails.api.materialApi.Logics.interfaces
{
    /// <summary>
    /// Create user material api logic interfase.
    /// </summary>
    public interface ICreateMaterialLogic
    {
        /// <summary>
        /// Create user material api logic.
        /// </summary>
        /// <param name="userMaterialModel">User material info pram.</param>
        /// <returns>Response message.</returns>
        public ApiResponse CreateUserMaterial(UserMaterialModel userMaterialModel);
    }
}
