using mycocktails.library.common.Models;

namespace mycocktails.api.materialApi.Logics.intarfaces
{
    /// <summary>
    /// Get material api logic intarfase.
    /// </summary>
    public interface IGetMaterialLogic
    {
        /// <summary>
        /// Get cocktail logic by id.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetMaterial(int id);

        /// <summary>
        /// Get cocktail list logic.
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetMaterialList();
    }
}
