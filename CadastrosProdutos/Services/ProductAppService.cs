using Cadastros.Domain.Entities;
using Cadastros.Domain.Interfaces;
using CadastrosProdutos.Interfaces;
using CadastrosProdutos.Models;
using System.Collections.Generic;

namespace CadastrosProdutos.Services
{
    public class ProductAppService : IProductAppService
    {
        // Injeção de dependência
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
        {
            _productService = productService;
        }

        // Ações do service
        public bool Add(ProductModel model)
        {
            var product = _productService.Add(ConvertToProduct(model));

            return product;
        }

        public bool Remove(int id)
        {
            var product = _productService.Delete(id);

            return product;
        }

        public bool Update(ProductModel model)
        {
            var product = _productService.Update(ConvertToProduct(model));

            return product;
        }

        public bool UpdateName(int id, string name)
        {
            return _productService.UpdateName(id, name);
        }

        public bool UpdatePrice(int id, decimal price)
        {
            return _productService.UpdatePrice(id, price);
        }

        public ProductModel GetById(int id)
        {
            var product = _productService.GetById(id);

            return ConvertToProductModel(product);
        }

        public IList<ProductModel> GetAll()
        {
            List<ProductModel> listProducts = new List<ProductModel>();

            foreach (var product in _productService.GetAll())
            {
                listProducts.Add(ConvertToProductModel(product));
            }

            return listProducts;
        }

        // Conversões
        private Product ConvertToProduct(ProductModel productModel)
        {
            return new Product(
                                productModel.UpdateAt,
                                productModel.Name,
                                productModel.Price,
                                productModel.Brand,
                                productModel.UpdateAt,
                                productModel.Id
                               );
        }

        private ProductModel ConvertToProductModel(Product product)
        {
            return new ProductModel()
            {
                Id = product.Id,
                UpdateAt = product.UpdateAt,
                CreatedAt = product.CreatedAt,
                Name = product.Name,
                Price = product.Price,
                Brand = product.Brand
            };
        }
    }
}
