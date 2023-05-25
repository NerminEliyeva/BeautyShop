using BeautyShop.Models.Entities;
using BeautyShop.Models.Request;
using BeautyShop.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Services.Interfaces
{
    public interface ICategoryBrandService
    {
        Task<BaseResponseModel<bool>> AddCategory(CategoryDto category);
        Task<BaseResponseModel<bool>> AddBrand(BrandDto brand);
        Task<BaseResponseModel<bool>> DeleteCategory(int categoryId);
        Task<BaseResponseModel<bool>> DeleteBrand(int brandId);
        Task<BaseResponseModel<List<CategoryDto>>> GetAllCategories();
        Task<BaseResponseModel<List<BrandDto>>> GetAllBrands();
        Task<BaseResponseModel<CategoryDto>> GetCategoryById(int id);
        Task<BaseResponseModel<BrandDto>> GetBrandById(int id);
    }
}
