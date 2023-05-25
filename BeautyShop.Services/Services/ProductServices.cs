using AutoMapper;
using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.Models.Entities;
using BeautyShop.Models.Request;
using BeautyShop.Models.Response;
using BeautyShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Services.Services
{
    public class ProductServices : IProductService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public ProductServices(IMapper mapper, IRepositoryWrapper repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<BaseResponseModel<bool>> AddProduct(ProductDto product)
        {
            var result = new BaseResponseModel<bool>();
            try
            {
                if (string.IsNullOrWhiteSpace(product.Name) || string.IsNullOrEmpty(product.Name))
                {
                    result.IsSuccess = false;
                    result.Obj = false;
                    result.Message = " boş ola bilməz";
                    return result;
                }
                if (string.IsNullOrWhiteSpace(product.Description) || string.IsNullOrEmpty(product.Description))
                {
                    result.IsSuccess = false;
                    result.Obj = false;
                    result.Message = "Kateqoriya adı boş ola bilməz";
                    return result;
                }
                if (string.IsNullOrWhiteSpace(product.Brand) || string.IsNullOrEmpty(product.Brand))
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

                await _repository.Category.Add(newCategory);
                _repository.Save();

                result.IsSuccess = true;
                result.Obj = true;
                result.Message = "Uğurlu əməliyyat";
                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Obj = false;
                result.Message = "Xəta baş verdi" + ex.ToString();
                return result;
            }
        }
    }
}
