using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.DAL.Concrete.Repository;
using BeautyShop.Models.Entitties;
using BeautyShop.Models.Request;
using BeautyShop.Models.Response;
using BeautyShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Services
{
    public class BeautyShopService : IBeautyShopService
    {
        private IProductRepository _productRepository;
        public BeautyShopService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }   

        public async Task<BaseResponseModel<bool>> AddCategory(CategoryDto category)
        {
            BaseResponseModel<bool> result = new BaseResponseModel<bool>();
            try
            {
                if (string.IsNullOrWhiteSpace(category.CategoryName) || string.IsNullOrEmpty(category.CategoryName))
                {
                    result.IsSuccess = false;
                    result.Obj = false;
                    result.Message = "Kateqoriya adı boş ola bilməz";
                    return result;
                }

                var newCategory = new Category
                {
                    CategoryName = category.CategoryName,
                };

               await _productRepository.Add<Category>(newCategory);
                _productRepository.Save();

                result.IsSuccess = true;
                result.Obj = true;
                result.Message = "Uğurlu əməliyyat";
                return result;
            }
            catch (Exception)
            {
                result.IsSuccess = false;
                result.Obj = false;
                result.Message = "Xəta baş verdi";
                return result;
            }
        }

        public BaseResponseModel<bool> AddBrand(BrandDto brand)
        {
            BaseResponseModel<bool> result = new BaseResponseModel<bool>();
            try
            {
                if (string.IsNullOrWhiteSpace(brand.BrandName) || string.IsNullOrEmpty(brand.BrandName))
                {
                    result.IsSuccess = false;
                    result.Obj = false;
                    result.Message = "Brend adı boş ola bilməz";
                    return result;
                }

                var newBrand = new Brand
                {
                    BrandName = brand.BrandName
                };

                _productRepository.Add(newBrand);
                _productRepository.Save();

                result.IsSuccess = true;
                result.Obj = true;
                result.Message = "Uğurlu əməliyyat";
                return result;
            }
            catch (Exception)
            {
                result.IsSuccess = false;
                result.Obj = false;
                result.Message = "Xəta baş verdi";
                return result;
            }
        }


    }
}
