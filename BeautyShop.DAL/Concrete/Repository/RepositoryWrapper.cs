using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.DAL.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.DAL.Concrete.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly BeautyShopDbContext _repoContext;

        private IBrandRepository _brandRepository;

        private ICategoryRepository _categoryRepository;

        private IProductRepository _productRepository;
        public IBrandRepository Brand
        {
            get => _brandRepository ??= new BrandRepository(_repoContext);
        }
        public ICategoryRepository Category
        {
            get => _categoryRepository ??= new CategoryRepository(_repoContext);
        }
        public IProductRepository Product
        {
            get => _productRepository ??= new ProductRepository(_repoContext);
        }
        public RepositoryWrapper(BeautyShopDbContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public int Save()
        {
           return _repoContext.SaveChanges();
        }
    }
}
