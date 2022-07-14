using Cadastros.Domain.Entities;
using Cadastros.Domain.Interfaces;
using System.Collections.Generic;

namespace Cadastros.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool Add(Product product) => _productRepository.Add(product);
       

        public bool Delete(int id) => _productRepository.Delete(id);


        public List<Product> GetAll() => _productRepository.GetAll();

        public Product GetById(int id) => _productRepository.GetById(id);


        public bool Update(Product product) => _productRepository.Update(product);

        public bool UpdateName(int id, string name)
        {
            var product = _productRepository.GetById(id);

            product.SetName(name);

            return _productRepository.Update(product);
        }

        public bool UpdatePrice(int id, decimal price)
        {
            var product = _productRepository.GetById(id);
            
            product.SetPrice(price);

            return _productRepository.Update(product);
        }
    }
}
