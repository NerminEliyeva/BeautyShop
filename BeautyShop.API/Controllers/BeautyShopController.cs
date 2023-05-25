using BeautyShop.Models.Entities;
using BeautyShop.Models.Request;
using BeautyShop.Models.Response;
using BeautyShop.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeautyShopController : ControllerBase
    {
        private readonly ICategoryBrandService _beautyShopService;
        public BeautyShopController(ICategoryBrandService beautyShopService)
        {
            _beautyShopService = beautyShopService;
        }

        [HttpPost("AddCategory")]
        public async Task<BaseResponseModel<bool>> AddCategory(CategoryDto category)
        {
            return await _beautyShopService.AddCategory(category);
        }

        [HttpPost("AddBrand")]
        public async Task<BaseResponseModel<bool>> AddBrand(BrandDto brand)
        {
            return await _beautyShopService.AddBrand(brand);
        }

        [HttpPost("DeleteCategory")]
        public async Task<BaseResponseModel<bool>> DeleteCategory(int categoryId)
        {
            return await _beautyShopService.DeleteCategory(categoryId);
        }

        [HttpPost("DeleteBrand")]
        public async Task<BaseResponseModel<bool>> DeleteBrand(int brandId)
        {
            return await _beautyShopService.DeleteCategory(brandId);
        }

        [HttpGet("GetAllCategories")]
        public async Task<BaseResponseModel<List<CategoryDto>>> GetAllCategories()
        {
            return await _beautyShopService.GetAllCategories();
        }

        [HttpGet("GetAllBrands")]
        public async Task<BaseResponseModel<List<BrandDto>>> GetAllBrands()
        {
            return await _beautyShopService.GetAllBrands();
        }

        [HttpGet("GetCategoryById")]
        public async Task<BaseResponseModel<CategoryDto>> GetCategoryById(int id)
        {
            return await _beautyShopService.GetCategoryById(id);
        }

        [HttpGet("GetBrandById")]
        public async Task<BaseResponseModel<BrandDto>> GetBrandById(int id)
        {
            return await _beautyShopService.GetBrandById(id);
        }
    }
}
