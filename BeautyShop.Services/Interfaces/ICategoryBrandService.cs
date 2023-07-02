using BeautyShop.Models.Request;
using BeautyShop.Models.Response;

namespace BeautyShop.Services.Interfaces
{
    public interface ICategoryBrandService
    {
        Task<BaseResponseModel<bool>> AddCategory(string category);
        Task<BaseResponseModel<bool>> AddBrand(string brand);
        Task<BaseResponseModel<bool>> DeleteCategory(int categoryId);
        Task<BaseResponseModel<bool>> DeleteBrand(int brandId);
        Task<BaseResponseModel<List<CategoryDto>>> GetAllCategories();
        Task<BaseResponseModel<List<BrandDto>>> GetAllBrands();
        Task<BaseResponseModel<CategoryDto>> GetCategoryById(int id);
        Task<BaseResponseModel<BrandDto>> GetBrandById(int id);
    }
}
