using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.Models.Entitties;
using BeautyShop.Models.Request;
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

        public bool AddCategory(CategoryDto category)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(category.CategoryName) || string.IsNullOrEmpty(category.CategoryName))
                {
                    return false;
                }

                var newCategory = new Category
                {
                    CategoryName = category.CategoryName,
                };

                _productRepository.Add(newCategory);
                _productRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddBrand(BrandDto brand)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(brand.BrandName) || string.IsNullOrEmpty(brand.BrandName))
                {
                    return false;
                }

                var newBrand = new Brand
                {
                    BrandName = brand.BrandName
                };

                _productRepository.Add(newBrand);
                _productRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
