using BeautyShop.Models.Entitties;
using BeautyShop.Models.Request;
using BeautyShop.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeautyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeautyShopController : ControllerBase
    {
        private readonly IBeautyShopService _beautyShopService;
        public BeautyShopController(IBeautyShopService beautyShopService)
        {
            _beautyShopService = beautyShopService;
        }


        [HttpPost("AddCategory")]
        public bool AddCategory(CategoryDto category)
        {
            return _beautyShopService.AddCategory(category);
        }
        [HttpPost("AddBrand")]
        public bool AddBrand(BrandDto brand)
        {
            return _beautyShopService.AddBrand(brand);
        }

    }

}
