using AutoMapper;
using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.DAL.Concrete.Repository;
using BeautyShop.Models.Entities;
using BeautyShop.Models.Request;
using BeautyShop.Models.Response;
using BeautyShop.Services.Interfaces;


namespace BeautyShop.Services
{
    public class BeautyShopService : IBeautyShopService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        public BeautyShopService(IMapper mapper, IRepositoryWrapper repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task<BaseResponseModel<bool>> AddCategory(CategoryDto category)
        {
            var result = new BaseResponseModel<bool>();
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
        public async Task<BaseResponseModel<bool>> AddBrand(BrandDto brand)
        {
            var result = new BaseResponseModel<bool>();
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

                await _repository.Brand.Add(newBrand);
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
        public async Task<BaseResponseModel<bool>> DeleteCategory(int categoryId)
        {
            var result = new BaseResponseModel<bool>();
            try
            {
                if (categoryId > 0)
                {
                    var categoryDetails = await _repository.Category.GetById(categoryId);
                    if (categoryDetails != null)
                    {
                        _repository.Category.Delete(categoryDetails);
                        var count = _repository.Save();

                        if (count > 0)
                        {
                            result.IsSuccess = true;
                            result.Obj = true;
                            result.Message = "Kateqoriya silindi";
                            return result;
                        }
                        else
                        {
                            result.IsSuccess = false;
                            result.Obj = false;
                            result.Message = "Kateqoriya tapılmadı";
                            return result;
                        }
                    }
                }
                result.IsSuccess = false;
                result.Obj = false;
                result.Message = "Kateqoriya tapılmadı";
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
        public async Task<BaseResponseModel<bool>> DeleteBrand(int brandId)
        {
            var result = new BaseResponseModel<bool>();
            try
            {
                if (brandId > 0)
                {
                    var brendDetails = await _repository.Brand.GetById(brandId);
                    if (brendDetails != null)
                    {
                        _repository.Brand.Delete(brendDetails);
                        var count = _repository.Save();

                        if (count > 0)
                        {
                            result.IsSuccess = true;
                            result.Obj = true;
                            result.Message = "Brend silindi";
                            return result;
                        }
                        else
                        {
                            result.IsSuccess = false;
                            result.Obj = false;
                            result.Message = "Brend tapılmadı";
                            return result;
                        }
                    }
                }
                result.IsSuccess = false;
                result.Obj = false;
                result.Message = "Brend tapılmadı";
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
        public async Task<BaseResponseModel<List<CategoryDto>>> GetAllCategories()
        {
            var model = new BaseResponseModel<List<CategoryDto>>();
            var categories = await _repository.Category.GetAll();

            var dto = _mapper.Map<List<CategoryDto>>(categories);
            try
            {
                if (!dto.Any())
                {
                    model.IsSuccess = false;
                    model.Message = "Məlumat tapılmadı";
                    return model;
                }
                model.Obj = dto;
                model.IsSuccess = true;
                model.Message = "Əməliyyat uğurludur";
                return model;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Xəta baş verdi" + ex.ToString();
                return model;
            }
        }
        public async Task<BaseResponseModel<List<BrandDto>>> GetAllBrands()
        {
            var model = new BaseResponseModel<List<BrandDto>>();
            var brands = await _repository.Brand.GetAll();

            var dto = _mapper.Map<List<BrandDto>>(brands);

            try
            {
                if (!dto.Any())
                {
                    model.IsSuccess = false;
                    model.Message = "Məlumat tapılmadı";
                    return model;
                }
                model.Obj = dto;
                model.IsSuccess = true;
                model.Message = "Əməliyyat uğurludur";
                return model;
            }
            catch (Exception ex)
            {

                model.IsSuccess = false;
                model.Message = "Xəta baş verdi" + ex.ToString();
                return model;
            }

        }
        public async Task<BaseResponseModel<CategoryDto>> GetCategoryById(int id)
        {
            var model = new BaseResponseModel<CategoryDto>();
            var category = await _repository.Category.GetById(id);

            var result = _mapper.Map<CategoryDto>(category);
            try
            {
                if (result is null)
                {
                    model.IsSuccess = false;
                    model.Message = "Məlumat tapılmadı";
                }
                else
                {
                    model.IsSuccess = true;
                    model.Obj = result;
                }
                return model;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Xəta baş verdi" + ex.ToString();
                return model;
            }
        }

        public async Task<BaseResponseModel<BrandDto>> GetBrandById(int id)
        {
            var model = new BaseResponseModel<BrandDto>();
            var brand = await _repository.Brand.GetById(id);

            var result = _mapper.Map<BrandDto>(brand);
            try
            {
                if (result is null)
                {
                    model.IsSuccess = false;
                    model.Message = "Məlumat tapılmadı";
                }
                else
                {
                    model.IsSuccess = true;
                    model.Obj = result;
                }
                return model;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Message = "Xəta baş verdi" + ex.ToString();
                return model;
            }
        }
    }
}
