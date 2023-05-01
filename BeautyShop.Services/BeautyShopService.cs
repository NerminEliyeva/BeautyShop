using BeautyShop.DAL.Abstract.IRepository;
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
    }
}
