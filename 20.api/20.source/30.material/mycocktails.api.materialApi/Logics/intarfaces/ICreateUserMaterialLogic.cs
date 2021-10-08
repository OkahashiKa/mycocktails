using mycocktails.library.common.Models;
using mycocktails.library.materialApi.Models;

namespace mycocktails.api.materialApi.Logics.intarfaces
{
    /// <summary>
    /// Create user material api logic intarfase.
    /// </summary>
    public interface ICreateUserMaterialLogic
    {
        /// <summary>
        /// Create user material api logic.
        /// </summary>
        /// <param name="userMaterialModel">User material info pram.</param>
        /// <returns></returns>
        public ApiResponse CreateUserMaterial(UserMaterialModel userMaterialModel);
    }
}
