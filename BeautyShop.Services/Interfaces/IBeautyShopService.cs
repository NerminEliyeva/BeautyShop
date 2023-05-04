using BeautyShop.Models.Entitties;
using BeautyShop.Models.Request;
using BeautyShop.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Services.Interfaces
{
    public interface IBeautyShopService
    {
        Task<BaseResponseModel<bool>> AddCategory(CategoryDto category);
        BaseResponseModel<bool> AddBrand(BrandDto brand);
    }
}
