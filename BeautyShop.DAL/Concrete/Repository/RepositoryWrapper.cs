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
        private BeautyShopDbContext _repoContext;

        private IBrandRepository _brandRepository;

        private ICategoryRepository _categoryRepository;

        private IProductRepository _productRepository;

        public IBrandRepository Brand
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new BrandRepository(_repoContext);
                }
                return _brandRepository;
            }
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_repoContext);
                }
                return _categoryRepository;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_repoContext);
                }
                return _productRepository;
            }
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
