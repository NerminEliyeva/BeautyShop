using BeautyShop.Models.Entitties;
using BeautyShop.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Services.Interfaces
{
    public interface IBeautyShopService
    {
        bool AddCategory(CategoryDto category);
        bool AddBrand(BrandDto brand);
    }
}
